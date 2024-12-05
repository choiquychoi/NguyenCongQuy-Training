using System;

class Program
{
    static void Main()
    {
        // Tạo đối tượng từ lớp Car
        Car myCar = new Car("Toyota", "Blue", 2023);

        // Sử dụng các phương thức của đối tượng
        myCar.DisplayInfo();
        myCar.Drive();
    }
}

class Car
{
    // Fields (Dữ liệu riêng)
    private string brand;
    private string color;
    private int year;

    // Constructor (Hàm khởi tạo)
    public Car(string brand, string color, int year)
    {
        this.brand = brand;
        this.color = color;
        this.year = year;
    }

    // Method (Hành vi của đối tượng)
    public void DisplayInfo()
    {
        Console.WriteLine($"Brand: {brand}, Color: {color}, Year: {year}");
    }

    public void Drive()
    {
        Console.WriteLine("The car is now driving.");
    }
}
