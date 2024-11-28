using System;

class Program
{
    // Phương thức ChangeValue trả về giá trị mới, không thay đổi biến ban đầu
    static int ChangeValue(int number)
    {
        number = 20; // Thay đổi giá trị của number trong phương thức
        Console.WriteLine("Inside method: " + number);
        return number; // Trả về giá trị mới
    }

    static void Main()
    {
        int num = 10; // Giữ nguyên giá trị ban đầu là 10
        Console.WriteLine("Before ChangeValue in Main: " + num);
        
        // Không thay đổi giá trị của num trong Main
        ChangeValue(num); // Thực hiện thay đổi giá trị trong phương thức
        Console.WriteLine("After ChangeValue in Main: " + num); // Giá trị vẫn là 10
    }

    static void tester()
    {
        int result = 0; // Khởi tạo giá trị cho result
        result = ChangeValue(result); // Lấy giá trị trả về từ phương thức ChangeValue
        Console.WriteLine("Value in tester: " + result); // In ra giá trị đã thay đổi
    }
}
