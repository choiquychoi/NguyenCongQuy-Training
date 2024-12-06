using System;

// Base class
class Animal
{
    // Method in the base class
    public void Eat()
    {
        Console.WriteLine("This animal eats food."); // Message for base class method
    }
}

// Derived class
class Dog : Animal
{
    // Method specific to the derived class
    public void Bark()
    {
        Console.WriteLine("The dog barks."); // Message for derived class method
    }
}

class Program
{
    static void Main()
    {
        // Create an object of the derived class
        Dog myDog = new Dog();

        // Call the method from the base class
        myDog.Eat(); // Inherited method

        // Call the method from the derived class
        myDog.Bark(); // Method specific to Dog class
    }
}
