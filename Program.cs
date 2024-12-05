using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "example.bin";

        // Open or create a binary file to write data
        using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
        {
            writer.Write(42); // Write an integer
            writer.Write(3.14); // Write a double
            writer.Write(true); // Write a boolean
            writer.Write("Binary data"); // Write a string
        }

        Console.WriteLine("Binary file has been written successfully."); // Inform user about the completion
    }
}
