
namespace bridge;

public class NotificationSender : IMessageSender
{
    private NotificationSender(){}
    
    public static NotificationSender Of()
    {
        return new NotificationSender();
    }
    public void SendMessage()
    {
        System.Console.WriteLine("Notification sent!!!");
    }
}