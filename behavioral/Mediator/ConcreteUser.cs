namespace Mediator;

public class ConcreteUser : User
{
    public ConcreteUser(IMediator mediator, string name)
        :base(mediator, name){}

    public override void Recieve(string message)
    {
        System.Console.WriteLine($"{name} : recieved <= {message}");
    }

    public override void Send(string message)
    {
        System.Console.WriteLine($"{name} : sent => {message}\n");
        mediator.SendMessage(message, this);
    }
}