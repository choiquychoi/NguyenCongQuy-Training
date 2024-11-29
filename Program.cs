using System;
using System.Linq;

namespace ihoclaptrinh
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num1 = { 5, 10, 15, 20, 25, 30 };
            Console.WriteLine("Max Value is: " + num1.Max());
            Console.WriteLine("Min value is: " + num1.Min());
            Console.WriteLine("Sum all Values in array is: " + num1.Sum());
            Console.ReadKey();
        }   
    }
}