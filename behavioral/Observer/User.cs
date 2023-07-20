namespace Observer;

public class User : IObserver
{
    public string Name {get;set;}
    
    public User(string name)
        => Name = name;

    public void Update(object sender, MessageEventArgs e)
    {
        System.Console.WriteLine($"\nMenssage recieved from: {e.Name};\n{e.Content}\n"
        + $"Observer: {this.Name}");
    }
}
