using System;

class Program
{
    static void Main(string[] args)
    {
        // Declare constants
        const float Pi = 3.14f; // Value of Pi
        const int DaysInWeek = 7; // Number of days in a week
        const string AppName = "My Application"; // Application name

        // Print constants
        Console.WriteLine("Value of Pi: " + Pi);
        Console.WriteLine("Number of days in a week: " + DaysInWeek);
        Console.WriteLine("Application Name: " + AppName);

        // Attempt to modify constant (will cause error)
        // Pi = 3.1415f; // Error: Cannot assign to 'Pi' because it is a constant
    }
}
