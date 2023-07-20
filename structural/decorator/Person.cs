namespace decorator
{
    //Concrete Component
    public sealed class Person : IPerson
    {
        //Operation
        public string Walk()
        {
            return "walking";
        }
    }
}