struct Point
{
    public int X;
    public int Y;

    // Constructor có tham số
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    // Phương thức hiển thị
    public void Display()
    {
        Console.WriteLine($"X: {X}, Y: {Y}");
    }
}

class Program
{
    static void Main()
    {
        // Tạo struct và khởi tạo giá trị
        Point p1 = new Point(10, 20);
        p1.Display(); // Output: X: 10, Y: 20

        // Khởi tạo bằng cách gán trực tiếp
        Point p2;
        p2.X = 30;
        p2.Y = 40;
        p2.Display(); // Output: X: 30, Y: 40
    }
}
