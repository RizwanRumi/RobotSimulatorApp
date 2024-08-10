import java.util.ArrayList;
import java.util.List;

interface IDataParser {
    List<DataBlock> parse(String[] lines);
}

public class DataParser implements IDataParser 
{
    public List<DataBlock> parse(String[] lines) 
    {
        List<DataBlock> dataBlocks = new ArrayList<>();
        int index = 0;

        while (index < lines.length) {
            // Skip any empty lines
            if (lines[index].trim().isEmpty()) {
                index++;
                continue;
            }

            // Parse the table size
            String[] tableSize = lines[index].split(" ");
            int rows = Integer.parseInt(tableSize[0]);
            int columns = Integer.parseInt(tableSize[1]);
            index++;

            // Parse the initial position and direction
            String[] initialPosition = lines[index].split(" ");
            int currentRow = Integer.parseInt(initialPosition[0]);
            int currentColumn = Integer.parseInt(initialPosition[1]);
            Direction currentDirection = Direction.valueOf(initialPosition[2]);
            index++;

            // Parse the commands
            String commands = lines[index];
            index++;

            // Add the block to the list
            DataBlock dataBlock = new DataBlock(rows, columns, currentRow, currentColumn, currentDirection, commands);
            dataBlocks.add(dataBlock);
        }

        return dataBlocks;
    }
}