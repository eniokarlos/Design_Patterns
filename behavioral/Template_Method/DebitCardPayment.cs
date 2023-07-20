namespace Template_Method;

public class DebitCardPayment : PaymentProcessor
{
    protected override void Debit()
    {
        System.Console.WriteLine("Using debit card");
    }
}