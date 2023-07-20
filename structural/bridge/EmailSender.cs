namespace bridge;

public class EmailSender : IMessageSender
{
    private EmailSender(){}
    public static EmailSender Of()
    {
        return new EmailSender();
    }

    public void SendMessage()
    {
        System.Console.WriteLine("Email sent!!!");
    }
}