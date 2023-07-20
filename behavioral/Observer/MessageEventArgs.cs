namespace Observer;

public class MessageEventArgs
{
    public string Name {get;set;}
    public string Content {get;set;}
    private MessageEventArgs(string name, string content)
    {
        Name = name;
        Content = content;
    }
    
    public static MessageEventArgs Of(string name, string content)
        => new MessageEventArgs(name, content);

}