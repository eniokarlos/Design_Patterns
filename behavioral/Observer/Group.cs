namespace Observer;

public class Group : ISubject
{
    private delegate void Handler<Args>(object? sender, Args args);
    private event Handler<MessageEventArgs>? OnNotify;
    public string Name {get;set;}

    public Group(string name)
        => Name = name;

    public void SendMessage(string message)
    {
        Notify(MessageEventArgs.Of(this.Name, message));
    }

    public void Notify(MessageEventArgs e)
    {
        if(OnNotify != null)
        {
            System.Console.WriteLine("\nSending Message...\n");
            OnNotify(this, e);
        }
        else
            System.Console.WriteLine("\nMessage cannot be sent\n");

    }

    public void Subscribe(IObserver observer)
    {
        System.Console.WriteLine($"\n{observer.Name} join on group: {this.Name}\n");
        OnNotify += observer.Update!;
    }

    public void Unsubscribe(IObserver observer)
    {
        System.Console.WriteLine($"\n{observer.Name} has left the group: {this.Name}\n");
        OnNotify -= observer.Update!;
    }
}