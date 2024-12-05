using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "example.txt";

        // Check if the file exists before attempting to read
        if (File.Exists(filePath))
        {
            // Read the file content using StreamReader
            using (StreamReader reader = new StreamReader(filePath))
            {
                string content = reader.ReadToEnd(); // Read the entire file
                Console.WriteLine("File content:"); 
                Console.WriteLine(content); // Display the content
            }
        }
        else
        {
            Console.WriteLine("The file does not exist!"); // Inform user if the file is missing
        }
    }
}
