using System;

class Program
{
    static void Main()
    {
        int a = 10, b = 20;

        // Biểu thức toán học
        int sum = a + b;

        // Biểu thức logic
        bool isGreater = a > b;

        // Biểu thức điều kiện
        string result = isGreater ? "A lớn hơn B" : "B lớn hơn hoặc bằng A";

        // Gọi phương thức
        Console.WriteLine($"Tổng: {sum}");
        Console.WriteLine($"Kết quả: {result}");
    }
}
