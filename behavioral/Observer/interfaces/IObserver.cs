namespace Observer;

public interface IObserver
{   
    string Name {get;set;}
    void Update(Object sender, MessageEventArgs e);
}