namespace composite
{
    public class Employee : IEmployed
    {
        public int Id {get;set;}
        public string Name {get;set;}
        private List<IEmployed> _subordinates = new List<IEmployed>();
        public IReadOnlyList<IEmployed> Subordinates => _subordinates as IReadOnlyList<IEmployed>;
        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public void AddSubordinate(IEmployed subodinate)
        {
            _subordinates.Add(subodinate);
        }

        public void RemoveSubordinate(IEmployed subodinate)
        {
            _subordinates.Remove(subodinate);
        }

    }
}