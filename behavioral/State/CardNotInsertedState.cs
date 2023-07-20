namespace State;

public class CardNotInsertedState : ICashMachineState
{
    private CardNotInsertedState(){}

    public static CardNotInsertedState Of()
        => new CardNotInsertedState();
    public void EjectCard(CashMachine context)
    {
        System.Console.WriteLine("Unable to eject card. Please insert card");
    }

    public void InsertCard(CashMachine context)
    {
        context.State = CardInsertedState.Of();
        System.Console.WriteLine("Card inserted with success!");
    }

    public void SetPassword()
    {
        System.Console.WriteLine("Unable to set password. Please insert card");
    }

    public void WithDraw()
    {
        System.Console.WriteLine("Unable to withdraw. Please insert card");
    }
}