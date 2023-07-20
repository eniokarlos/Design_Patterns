namespace bridge;

public class UserMessage : Message
{
    public UserMessage(IMessageSender messageSender) : base(messageSender)
    {
    }

    public override void Send()
    {
        System.Console.Write("From User: ");
        _messageSender.SendMessage();
    }
}