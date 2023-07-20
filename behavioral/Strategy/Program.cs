using Strategy;

SortedList records = SortedList.Of(new QuickSort());

records.Add("name1");
records.Add("name2");
records.Add("name3");
records.Add("name4");
records.Add("name5");

records.Sort();

records.SetSortStrategy(new ShellSort());

records.Sort();

records.SetSortStrategy(new MergeSort());

records.Sort();