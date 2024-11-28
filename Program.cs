using System;

class Program
{
    static int AddNumbers(int a, int b)
    {
        return a + b; // Return the sum of a and b
    }

    static void Main()
    {
        int result = AddNumbers(5, 10); // Store the returned value in the variable result
        Console.WriteLine("The sum is: " + result); // Display the result
    }
}