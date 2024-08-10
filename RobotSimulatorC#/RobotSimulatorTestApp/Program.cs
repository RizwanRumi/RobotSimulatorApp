using RobotSimulatorTestApp;
using System.Drawing;
using System.Reflection.PortableExecutable;



public class Program
{    
    static void Main(string[] args)
    {        
        string path = @"C:\Personal_project\RobotSimulatorC#\RobotSimulatorTestApp\files\input.txt";

        var dataParser = new DataParser();
        
        try
        {
            if (File.Exists(path))
            {
                // Read the entire file content
                string[] lines = File.ReadAllLines(path);

                var dataBlocks = dataParser.Parse(lines);

                foreach (var block in dataBlocks)
                {
                    Console.WriteLine("\nInput:");
                    Console.WriteLine($"{block.Rows} {block.Columns}");
                    Console.WriteLine($"{block.CurrentRow}, {block.CurrentColumn}, {block.CurrentDirection}");
                    Console.WriteLine($"{block.Commands}");
                    Console.WriteLine();

                    int rows = block.Rows;
                    int cols = block.Columns;
                    int currentRow = block.CurrentRow;
                    int currentCol = block.CurrentColumn;
                    Direction currentDirection = (Direction)Enum.Parse(typeof(Direction), value: Convert.ToString(block.CurrentDirection));

                    RobotSimulator robotSimulator = new RobotSimulator();

                   
                    // Process commands
                    string status = "";
                    foreach (char command in block.Commands)
                    {

                        switch (command)
                        {
                            case 'M':
                                robotSimulator.Move(ref currentRow, ref currentCol, currentDirection, rows, cols);
                                status = "Position";
                                break;
                            case 'R':
                                currentDirection = robotSimulator.RotateRight(currentDirection);
                                status = "location";
                                break;
                            case 'L':
                                currentDirection = robotSimulator.RotateLeft(currentDirection);
                                status = "location";
                                break;
                        }

                       Console.WriteLine($"Current {status}: {currentRow} {currentCol} {currentDirection}");
                    }

                    // Output the final position and direction
                    Console.WriteLine($"Output : {currentRow} {currentCol} {currentDirection}");

                    
                }
            }
            else
            {
                Console.WriteLine("File directory path is Not available, please check!");
            }

        }
        catch (Exception e)
        {
            Console.WriteLine("The process failed: {0}", e.ToString());
        }


       
    }

    
}





