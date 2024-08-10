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





