namespace decorator
{
    //Decorator
    public class FastPersonDecorator : IPerson
    {
        public IPerson p;

        public FastPersonDecorator(IPerson p)
        {
            this.p = p;
        }

        public string Walk()
        {
            return new String(p.Walk() + " fast");
        }

        public string Run()
        {
            return "running";
        }
    }
}