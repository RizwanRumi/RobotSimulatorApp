using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotSimulatorTestApp
{
    public interface IDataParser
    {
        List<DataBlock> Parse(string[] lines);
    }

    public class DataParser : IDataParser
    {
        public List<DataBlock> Parse(string[] lines)
        {
            var dataBlocks = new List<DataBlock>();
            int index = 0;

            while (index < lines.Length)
            {
                // Skip any empty lines
                if (string.IsNullOrWhiteSpace(lines[index]))
                {
                    index++;
                    continue;
                }

                // Parse the table size
                string[] tableSize = lines[index].Split(' ');
                int rows = int.Parse(tableSize[0]);
                int columns = int.Parse(tableSize[1]);
                index++;

                // Parse the initial position and direction
                string[] initialPosition = lines[index].Split(' ');
                int currentRow = int.Parse(initialPosition[0]);
                int currentColumn = int.Parse(initialPosition[1]);
                Direction currentDirection = (Direction)Enum.Parse(typeof(Direction), initialPosition[2]);
                index++;

                // Parse the commands
                string commands = lines[index];
                index++;

                // Add the block to the list
                DataBlock dataBlock = new DataBlock(rows, columns, currentRow, currentColumn, currentDirection, commands);
                dataBlocks.Add(dataBlock);

            }

            return dataBlocks;
        }
    }
}
