namespace Memento1;

public class CareTaker
{
    public Memento Memento {get;set;}

    public CareTaker(Memento memento)
    {
        Memento = memento;
    }
}