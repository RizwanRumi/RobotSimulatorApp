import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Paths;
import java.util.List;

public class Program {

    public static void main(String[] args) 
    {
        String path = "C:/Personal_project/RobotSimulatorJava/files/input.txt";

        DataParser dataParser = new DataParser();

        try {
            if (Files.exists(Paths.get(path))) {
                // Read the entire file content
                List<String> lines = Files.readAllLines(Paths.get(path));

                List<DataBlock> dataBlocks = dataParser.parse(lines.toArray(new String[0]));

                for (DataBlock block : dataBlocks) {
                    System.out.println("Input:");
                    System.out.println(block.getRows() + " " + block.getColumns());
                    System.out.println(block.getCurrentRow() + ", " + block.getCurrentColumn() + ", " + block.getCurrentDirection());
                    System.out.println(block.getCommands());
                    System.out.println();

                }
            } else {
                System.out.println("File directory path is not available, please check!");
            }
        } catch (IOException e) {
            System.out.println("The process failed: " + e.toString());
        }
    }
}
