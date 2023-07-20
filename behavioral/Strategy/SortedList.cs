namespace Strategy;

public class SortedList
{
    private List<string> list = new List<string>();
    private SortStrategy sortStrategy;

    private SortedList(SortStrategy sortStrategy)
        => this.sortStrategy = sortStrategy;

    public static SortedList Of(SortStrategy sortStrategy)
        => new SortedList(sortStrategy);
          
    public void SetSortStrategy(SortStrategy strategy)
        => this.sortStrategy = strategy;

        public void Add(string name)
            => list.Add(name);

        public void Sort()
        {
            sortStrategy.Sort(list);

            foreach(string name in list)
            {
                System.Console.WriteLine(" " + name);
            }


        }
}