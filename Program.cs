using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "example.txt";

        // Create and write to the file using StreamWriter
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine("Hello, World!"); // Write a simple text
            writer.WriteLine("This is a new line in the file."); // Add another line
        }

        Console.WriteLine("File has been written successfully."); // Inform user about the completion
    }
}
