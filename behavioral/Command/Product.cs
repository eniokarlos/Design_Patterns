namespace Command;

public class Product 
{
    public string Name {get;set;}
    public int Price {get;set;}

    public Product(string name, int price)
    {
        Name = name;
        Price = price;
    }

    public void IncreasePrice(int value)
    {
        Price += value;
        Console.WriteLine($"{Name} price has been increased in R$ {value}");
    }

    public void DecreasePrice(int value)
    {
        Price -= value;
        Console.WriteLine($"{Name} price has been decreased in R$ {value}");
    }

    public override string ToString() => $"{Name} current price is R$ {Price}";
}