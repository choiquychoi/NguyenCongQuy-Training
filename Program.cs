using System;

// A delegate that takes a string and returns nothing
delegate void GreetDelegate(string name);

class Program
{
    static void GreetInEnglish(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }

    static void GreetInVietnamese(string name)
    {
        Console.WriteLine($"Xin chào, {name}!");
    }

    static void Main()
    {
        // Assign the delegate to GreetInEnglish
        GreetDelegate greet = GreetInEnglish;
        greet("Alice"); // Output: Hello, Alice!

        // Reassign the delegate to GreetInVietnamese
        greet = GreetInVietnamese;
        greet("Alice"); // Output: Xin chào, Alice!
    }
}
