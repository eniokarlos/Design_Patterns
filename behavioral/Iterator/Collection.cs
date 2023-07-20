
namespace Iterator;

public class Collection<T> : ICollection<T>
{
    private List<T> _list = new List<T>();
    public int Count {get => _list.Count();}

    public IIterator<T> CreateIterator()
        => new ConcreteIterator<T>(this);

    public T Get(int position)
    {
        return _list[position];
    }

    public void Add(T item)
    {
        _list.Add(item);
    }

}