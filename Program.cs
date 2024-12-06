using System;

class Person
{
    // Private field: hides the details of the implementation
    private string name;

    // Public property: provides controlled access to the private field
    public string Name
    {
        get { return name; } // Getter: retrieve the value of the private field
        set 
        { 
            if (!string.IsNullOrWhiteSpace(value)) // Validation check
            {
                name = value; 
            }
            else
            {
                Console.WriteLine("Name cannot be empty.");
            }
        }
    }
}

class Program
{
    static void Main()
    {
        Person person = new Person();

        // Setting the name using the property
        person.Name = "John";
        Console.WriteLine($"Person's Name: {person.Name}"); // Output: Person's Name: John

        // Trying to set an invalid value
        person.Name = ""; // Output: Name cannot be empty.
    }
}
