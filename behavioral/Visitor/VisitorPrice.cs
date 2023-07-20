namespace Visitor;

public class VisitorPrice : IVisitor
{
    private const int CAR_DISCOUNT = 12;

    public void Accept(Car car)
    {
        decimal CarPriceAfterDiscount = car.Price
            -((car.Price / 100) * CAR_DISCOUNT);

        System.Console.WriteLine($"Car: {car.Name}; Price after discount: {CarPriceAfterDiscount}");
    }
}