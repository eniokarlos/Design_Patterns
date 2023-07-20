namespace Command;

public class IncreaseProductPriceCommand : ICommand
{
    private readonly Product _product;
    private readonly int Value;

    private IncreaseProductPriceCommand(Product product, int value)
    {
        _product = product;
        Value = value;
    }

    public static IncreaseProductPriceCommand Of(Product product, int value)
    {
        return new IncreaseProductPriceCommand(product, value);
    }

    public void Execute() => _product.IncreasePrice(Value);
    
    public void Undo() => _product.DecreasePrice(Value);
}