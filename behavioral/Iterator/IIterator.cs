namespace Iterator;

public interface IIterator<T>
{
    T First();
    T Next();
    bool IsDone {get;}
}