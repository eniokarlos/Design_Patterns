namespace factoryMethod
{
    public abstract class Pizza
    {
        protected string Name {get;set;}

        public string Prepare()
        {
            return "Preparing " + Name;
        }
    }
}