using System;

class Program
{
    static void Initialize(out int number)
    {
        number = 100; // Assign a value
    }

    static void Main()
    {
        int num; // No need to initialize
        Initialize(out num); // Pass by reference with `out`
        Console.WriteLine("Initialized value: " + num);
    }
}
