namespace State;

public class CardInsertedState : ICashMachineState
{
    private CardInsertedState(){}

    public static CardInsertedState Of()
        => new CardInsertedState();
        
    public void EjectCard(CashMachine context)
    {
        context.State = CardNotInsertedState.Of();
        System.Console.WriteLine("Card ejected with success");
    }

    public void InsertCard(CashMachine context)
    {
        System.Console.WriteLine("Unable to insert card. Card has already been inserted");
    }

    public void SetPassword()
    {
        System.Console.WriteLine("Password defined with success!");
    }

    public void WithDraw()
    {
        System.Console.WriteLine("Money withDrawn with success!");
    }
}