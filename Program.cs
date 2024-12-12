using System;

// Abstract class
abstract class Shape
{
    public abstract double CalculateArea(); // Abstract method
    public void Display()
    {
        Console.WriteLine("This is a shape."); // Normal method
    }
}

// Derived class: Circle
class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    // Implement the abstract method
    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius; // Area of circle
    }
}

// Derived class: Rectangle
class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    // Implement the abstract method
    public override double CalculateArea()
    {
        return Width * Height; // Area of rectangle
    }
}

class Program
{
    static void Main()
    {
        Shape circle = new Circle(5);
        Shape rectangle = new Rectangle(4, 6);

        circle.Display();
        Console.WriteLine($"Circle Area: {circle.CalculateArea()}"); // Output: Circle Area: 78.53981633974483

        rectangle.Display();
        Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea()}"); // Output: Rectangle Area: 24
    }
}
