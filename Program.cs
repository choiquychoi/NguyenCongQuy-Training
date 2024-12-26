using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<string> tasks = new Queue<string>();

        // add more tasks
        tasks.Enqueue("Task 1");
        tasks.Enqueue("Task 2");
        tasks.Enqueue("Task 3");

        // delete all tasks
        tasks.Clear();
        Console.WriteLine($"Number of tasks: {tasks.Count}");
    }
}
