namespace Mediator;

public class GroupMediator : IMediator
{
    private List<User> _userList = new List<User>();
    
    public void RegisterUser(User user)
    {
        _userList.Add(user);
    }

    public void SendMessage(string message, User sender)
    {
        foreach(var user in _userList)
        {
            if(user != sender)
            {
                user.Recieve(message);
            }


        }
    }
}