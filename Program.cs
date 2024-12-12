using System;
using System.Text;

class Program
{
    delegate int MyDelegate(string s);
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;           

        MyDelegate showString = new MyDelegate(ShowString);            

        InputAndShowName(showString);

Console.ReadLine();
    }

    static void InputAndShowName(MyDelegate showName)
    {
        Console.WriteLine("Input your name please:");
        string name = Console.ReadLine();
        showName(name);
    }

    static int ShowString(string stringValue)
    {
        Console.WriteLine(stringValue);
        return 0;
    }
}





