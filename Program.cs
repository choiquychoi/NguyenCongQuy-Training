using System;

// Define the first interface
interface IMovable
{
    void Move(); // Abstract method
}

// Define the second interface
interface IWorkable
{
    void Work(); // Abstract method
}

// Class implementing both interfaces
class Robot : IMovable, IWorkable
{
    // Implement Move from IMovable
    public void Move()
    {
        Console.WriteLine("The robot is moving.");
    }

    // Implement Work from IWorkable
    public void Work()
    {
        Console.WriteLine("The robot is working.");
    }
}

class Program
{
    static void Main()
    {
        Robot robot = new Robot();

        // Call methods from both interfaces
        robot.Move(); // Output: The robot is moving.
        robot.Work(); // Output: The robot is working.
    }
}
