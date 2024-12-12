using System;

delegate void NotificationDelegate(string message);

class Program
{
    static void NotifyViaEmail(string message)
    {
        Console.WriteLine($"Email notification: {message}");
    }

    static void NotifyViaSMS(string message)
    {
        Console.WriteLine($"SMS notification: {message}");
    }

    static void Main()
    {
        NotificationDelegate notify = NotifyViaEmail;
        notify += NotifyViaSMS; // Thêm phương thức NotifyViaSMS vào delegate

        notify("You have a new message!"); 
        // Output:
        // Email notification: You have a new message!
        // SMS notification: You have a new message!

        notify -= NotifyViaEmail; // Loại bỏ phương thức NotifyViaEmail
        notify("Another message!"); 
        // Output:
        // SMS notification: Another message!
    }
}
