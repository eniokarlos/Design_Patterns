namespace Iterator;

public class ConcreteIterator<T> : IIterator<T>
{
    private int _current = 0;
    private int _step = 1;
    private Collection<T> _collection;

    public ConcreteIterator(Collection<T> collection)
    {
        _collection = collection;
    }

    public bool IsDone {get => _current >= _collection.Count;}

    public T First()
    {
        _current = 0;
        return _collection.Get(_current);
    }

    public T Next()
    {
        _current += _step;
        if(!IsDone){
            return _collection.Get(_current);
        }
        else
        {
            _current = _collection.Count;
            return _collection.Get(_current-1);
        }
    }
}