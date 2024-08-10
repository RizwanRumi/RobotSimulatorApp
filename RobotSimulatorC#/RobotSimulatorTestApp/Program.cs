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
                                        
                    RobotSimulator robotSimulator = new RobotSimulator();

                    IRotation rotation;
                    
                    // Process commands
                    string status = "";
                    foreach (char command in block.Commands)
                    {

                        switch (command)
                        {
                            case 'M':
                                robotSimulator.Move(block);                                
                                status = "Position";
                                break;
                            case 'R':
                                rotation = new RotateRight();
                                block.CurrentDirection = robotSimulator.SelectedRotation(rotation, block.CurrentDirection);                                
                                status = "location";
                                break;
                            case 'L':
                                rotation = new RotateLeft();
                                block.CurrentDirection = robotSimulator.SelectedRotation(rotation, block.CurrentDirection);                               
                                status = "location";
                                break;
                        }

                        Console.WriteLine($"Current {status}: {block.CurrentRow} {block.CurrentColumn} {block.CurrentDirection}");
                        
                    }

                    // Output the final position and direction
                    Console.WriteLine($"Output: {block.CurrentRow} {block.CurrentColumn} {block.CurrentDirection}");                    
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





