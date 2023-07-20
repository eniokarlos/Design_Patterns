namespace bridge;

public class SystemMessage : Message
{
    public SystemMessage(IMessageSender messageSender) : base(messageSender)
    {}

    public override void Send()
    {
        System.Console.Write("From System: ");
        _messageSender.SendMessage();
    }
}