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
                    System.out.println("\nInput:");
                    System.out.println(block.getRows() + " " + block.getColumns());
                    System.out.println(block.getCurrentRow() + ", " + block.getCurrentColumn() + ", " + block.getCurrentDirection());
                    System.out.println(block.getCommands());
                    System.out.println();
 
                    RobotSimulator robotSimulator = new RobotSimulator();

                    IRotation rotation;

                    // Process commands
                    String status = "";
                    for (char command : block.getCommands().toCharArray()) {
                        switch (command) {
                            case 'M':
                                robotSimulator.move(block);
                                status = "Position";
                                break;
                            case 'R':
                                rotation = new RotateRight();
                                block.setCurrentDirection(robotSimulator.selectedRotation(rotation, block.getCurrentDirection()));
                                status = "location";
                                break;
                            case 'L':
                                rotation = new RotateLeft();
                                block.setCurrentDirection(robotSimulator.selectedRotation(rotation, block.getCurrentDirection()));
                                status = "location";
                                break;
                        }

                        System.out.println("Current " + status + ": " + block.getCurrentRow() + " " + block.getCurrentColumn() + " " + block.getCurrentDirection());
                    }

                    // Output the final position and direction
                    System.out.println("Output: " + block.getCurrentRow() + " " + block.getCurrentColumn() + " " + block.getCurrentDirection()); 
                }
            } else {
                System.out.println("File directory path is not available, please check!");
            }
        } catch (IOException e) {
            System.out.println("The process failed: " + e.toString());
        }
    }
}
