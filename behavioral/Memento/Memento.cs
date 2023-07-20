namespace Memento1;

public class Memento
{
    public string Name {get;set;}
    public double Budget {get;set;}

    public Memento(string name, double budget)
    {
        Name = name;
        Budget = budget;
    }
}