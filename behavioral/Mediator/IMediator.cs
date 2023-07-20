namespace Mediator;

public interface IMediator
{
    void SendMessage(string message, User user);
    void RegisterUser(User user);
}