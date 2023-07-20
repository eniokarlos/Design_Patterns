namespace factoryMethod;
public class Program
{
    public static void Main(string[] args)
    {
        var factory = new CeFactory();
        var pizza = factory.Create(1);
        System.Console.WriteLine(pizza.Prepare());
    }

}
