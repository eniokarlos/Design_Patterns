namespace singleton
{
    public class SingletonThreadSafety
    {
        private static SingletonThreadSafety instance;
        private static readonly object lockObject = new Object();
        private int numberOfInstances = 0;

        private SingletonThreadSafety()
        {
            numberOfInstances++;
            System.Console.WriteLine($"N° Instances = {numberOfInstances}");
        }

        public static SingletonThreadSafety Instance
        {
            get
            {
                if(instance == null)
                {
                    lock (lockObject)
                    {
                        if(instance == null)
                        instance = new SingletonThreadSafety();
                    }
                }
                return instance;
            }
        }
    }

    public sealed class SingletonThreadSafety2
    {
        private static SingletonThreadSafety2 instance;

        private SingletonThreadSafety2(){}

        static SingletonThreadSafety2()
        {
            instance = new SingletonThreadSafety2();
        }

        public static SingletonThreadSafety2 Instance
        {
            get
            {
                return instance;
            }
        }        
    }
}