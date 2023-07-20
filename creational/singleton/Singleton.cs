namespace singleton
{
    public class Singleton
    {
        private static Singleton instance;
        private int numberOfInstances = 0;

        private Singleton()
        {
            numberOfInstances++;
            System.Console.WriteLine($"N° Instances = {numberOfInstances}");
        }

        public static Singleton Instance
        {
            get
            {
                if(instance == null)
                    instance = new Singleton();
                return instance;
            }
        }
    }
}