using System;

public class Publisher
{
    // 1. Khai báo delegate
    public delegate void NotifyEventHandler(string message);

    // 2. Khai báo event dựa trên delegate
    public event NotifyEventHandler Notify;

    // Phương thức kích hoạt sự kiện
    public void TriggerEvent()
    {
        Console.WriteLine("Publisher: Triggering the event...");
        Notify?.Invoke("Hello, this is an event notification!");
    }
}

public class Subscriber
{
    // Phương thức xử lý sự kiện
    public void OnNotify(string message)
    {
        Console.WriteLine($"Subscriber received: {message}");
    }
}

class Program
{
    static void Main()
    {
        Publisher publisher = new Publisher();
        Subscriber subscriber = new Subscriber();

        // 3. Đăng ký sự kiện
        publisher.Notify += subscriber.OnNotify;

        // Kích hoạt sự kiện
        publisher.TriggerEvent();

        // 4. Hủy đăng ký sự kiện (nếu cần)
        publisher.Notify -= subscriber.OnNotify;
    }
}
