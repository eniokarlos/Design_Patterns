namespace Iterator;

public interface ICollection<T>
{
    IIterator<T> CreateIterator();
}