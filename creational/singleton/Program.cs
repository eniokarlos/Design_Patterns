using singleton;

internal class Program
{
    static SingletonThreadSafety2 s1;
    static SingletonThreadSafety2 s2;
    static void Main(string[] args)
    {
        Parallel.Invoke(
            () => AccessThread1(),
            () => AccessThread2()
        );
        Compare(s1, s2);
    }

    private static void AccessThread1()
    {
        s1 = SingletonThreadSafety2.Instance;
        System.Console.WriteLine("Thread 1");
    }

    private static void AccessThread2()
    {
        s2 = SingletonThreadSafety2.Instance;
        System.Console.WriteLine("Thread 2");
    }

    private static void Compare(SingletonThreadSafety2 s1, SingletonThreadSafety2 s2)
    {
        string result = s1 == s2 ? "Is equal" : "Is Different";

        System.Console.WriteLine(result);
    }
}