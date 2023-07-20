namespace Template_Method;

public class CreditCardPayment : PaymentProcessor
{
    protected override void Debit()
    {
        System.Console.WriteLine("Using Credit card");
    }
}