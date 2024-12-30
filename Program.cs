using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;


class MyClass {
    // chuẩn bị 1 phương thức static để thực thi công việc
    static void DoSomeThing (int seconds, string msg, ConsoleColor color)
    {
        lock( Console.Out) 
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"{msg, 10} ... Start");
            Console.ResetColor();
        }
        
        for (int i = 1; i <= seconds; i++)
        {
            lock( Console.Out) 
            {
                Console.ForegroundColor = color;
                Console.WriteLine($"{msg, 10} {i, 2}");
                Console.ResetColor();

                Thread.Sleep(1000);
            }
        }

        lock( Console.Out) 
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"{msg, 10} ... End!");
            Console.ResetColor();
        }
    }


    static async Task Task2() 
    {
         // Task 
        Task t2 = new Task (
            () => {
                DoSomeThing(10, "Task 2", ConsoleColor.Magenta);
            }
        );

        t2.Start();
        await t2; // wait for task 2 done

        Console.WriteLine("Task 2 done");
    }

    static async Task Task3 (){
        Task t3 = new Task (
            (object ob) => {
                string tenTacVu = (string) ob;
                DoSomeThing(4, tenTacVu, ConsoleColor.Blue);
            }
        , "Task 3");

        t3.Start();

        await t3;
        Console.WriteLine("Task 3 done");
    }

        
    static void Main( string[] args)
    {
        Task t2 = Task2();
        Task t3 = Task3();

        // synchronous
        DoSomeThing(6, "Task 1", ConsoleColor.Yellow);

        Task.WaitAll(t2, t3);

        Console.WriteLine("Done");
        Console.ReadKey();
    }
}


