using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "example.bin";

        // Check if the binary file exists before attempting to read
        if (File.Exists(filePath))
        {
            // Open and read the binary file
            using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
            {
                int number = reader.ReadInt32(); // Read an integer
                double value = reader.ReadDouble(); // Read a double
                bool flag = reader.ReadBoolean(); // Read a boolean
                string text = reader.ReadString(); // Read a string

                // Display the read data
                Console.WriteLine($"Integer: {number}");
                Console.WriteLine($"Double: {value}");
                Console.WriteLine($"Boolean: {flag}");
                Console.WriteLine($"String: {text}");
            }
        }
        else
        {
            Console.WriteLine("The binary file does not exist!"); // Inform user if the file is missing
        }
    }
}
