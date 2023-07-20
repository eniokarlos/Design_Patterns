namespace Strategy;

public class ShellSort : SortStrategy
{
    public override void Sort(List<string> list)
    {
        list.Sort();
        System.Console.WriteLine("ShellSorted list");
    }
}

