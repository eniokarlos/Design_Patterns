using Iterator;

Collection<int> collection = new Collection<int>();
collection.Add(2);
collection.Add(6);
collection.Add(7);
collection.Add(30);

IIterator<int> iterator = collection.CreateIterator();

for(var item = iterator.First(); !iterator.IsDone; item = iterator.Next())
{
    System.Console.WriteLine(item);
}
