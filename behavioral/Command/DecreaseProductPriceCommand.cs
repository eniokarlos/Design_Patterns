namespace Command;

public class DecreaseProductPriceCommand : ICommand
{
    private readonly Product _product;
    private readonly int Value;

    private DecreaseProductPriceCommand(Product product, int value)
    {
        _product = product;
        Value = value;
    }

    public static DecreaseProductPriceCommand Of(Product product, int value)
    {
        return new DecreaseProductPriceCommand(product, value);
    }
    public void Execute() => _product.DecreasePrice(Value);
    
    public void Undo() => _product.IncreasePrice(Value);
}