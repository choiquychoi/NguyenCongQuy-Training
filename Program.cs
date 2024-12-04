using System;

class Program
{
    static void Main()
    {
        try
        {
            ValidateNumber(-1);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static void ValidateNumber(int number)
    {
        if (number < 0)
        {
            throw new ArgumentException("Number cannot be negative."); // Throw exception
        }
    }
}
