// Tạo interface send message
public interface IMessageSender
{
    void SendMessage(string subject, string body);
}

// Concrete Implementor cho send mail
public class EmailSender : IMessageSender
{
    public void SendMessage(string subject, string body)
    {
        Console.WriteLine($"Sending Email\nSubject: {subject}\nBody: {body}");
    }
}

// Concrete Implementor cho send sms
public class SmsSender : IMessageSender
{
    public void SendMessage(string subject, string body)
    {
        Console.WriteLine($"Sending SMS\nSubject: {subject}\nBody: {body}");
    }
}

// Tạo abstract class message
public abstract class Message
{
    protected IMessageSender _messageSender;

    protected Message(IMessageSender messageSender)
    {
        _messageSender = messageSender;
    }

    public abstract void Send(string subject, string body);
}

// Cải tiến abstract cho thông báo hệ thống
public class SystemAlert : Message
{
    public SystemAlert(IMessageSender messageSender) : base(messageSender) { }

    public override void Send(string subject, string body)
    {
        Console.WriteLine("System Alert:");
        _messageSender.SendMessage(subject, body);
    }
}

// Cải tiến abstract cho thông báo người dùng
public class UserNotification : Message
{
    public UserNotification(IMessageSender messageSender) : base(messageSender) { }

    public override void Send(string subject, string body)
    {
        Console.WriteLine("User Notification:");
        _messageSender.SendMessage(subject, body);
    }
}

class Program
{
    static void Main(string[] args)
    {
        IMessageSender emailSender = new EmailSender();
        IMessageSender smsSender = new SmsSender();

        Message systemAlertEmail = new SystemAlert(emailSender);
        Message userNotificationSms = new UserNotification(smsSender);

        // Thông báo hệ thống qua mail
        systemAlertEmail.Send("System is down", "Please take necessary action!");
        Console.WriteLine();
        //Thông báo người dùng qua sms
        userNotificationSms.Send("New message received", "Please check your inbox!");
    }
}
