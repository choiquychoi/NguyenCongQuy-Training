using System;

class Program
{
    // Method that takes parameters and returns a value
    static int AddNumbers(int a, int b)
    {
        return a + b;  // Add a and b, then return the result
    }

    static void Main(string[] args)
    {
        // Call the AddNumbers method
        int sum = AddNumbers(5, 7);
        Console.WriteLine("The sum is: " + sum);
    }
}
