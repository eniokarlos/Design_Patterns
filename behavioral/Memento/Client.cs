namespace Memento1;

public class Client
{
    public string Name { get; set; }
    public double Budget { get; set; }

    public Client(string name, double budget)
    {
        Name = name;
        Budget = budget;
    }

    public Memento SaveMemento()
    {
        Console.WriteLine("\nSaving state --\n");
        return new Memento(Name, Budget);
    }

    public void RestoreMemento(Memento memento)
    {
        Console.WriteLine("\nRestoring state --\n");
            Name = memento.Name;
            Budget = memento.Budget;
    }

    public override string ToString()
    {
        return $"Name: {Name}; Budget: {Budget}";
    }
}