namespace Strategy;

public class MergeSort : SortStrategy
{
    public override void Sort(List<string> list)
    {
        list.Sort();
        System.Console.WriteLine("MergeSorted list");
    }
}

