namespace bridge;

public abstract class Message
{
    protected readonly IMessageSender _messageSender;

    protected Message(IMessageSender messageSender)
    {
        _messageSender = messageSender;
    }
    

    public abstract void Send(); 
}