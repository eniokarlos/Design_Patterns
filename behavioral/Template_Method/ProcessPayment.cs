namespace Template_Method;

public abstract class PaymentProcessor
{
    public void Process()
    {
        Prepare();
        Validate();
        Debit();
        Notify();
        Finish();
    }

    protected abstract void Debit();
    private void Prepare()
        => System.Console.WriteLine("Reserving products");

    private void Validate()
        => System.Console.WriteLine("Validating products");

    private void Notify()
        => System.Console.WriteLine("Notifying user");

    private void Finish()
        => System.Console.WriteLine("Finishing");
}