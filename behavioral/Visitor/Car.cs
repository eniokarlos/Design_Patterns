namespace Visitor;

public class Car : IElement
{
    public string Name {get;set;}
    public decimal Price { get; set; }
    
    public Car(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public void Visit(IVisitor visitor)
    {
        visitor.Accept(this);
    }
}