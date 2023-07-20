namespace State;

public class CashMachine
{
    public ICashMachineState State {get;set;}

    public CashMachine()
        => State = CardNotInsertedState.Of();
    
    public void InsertCard()
        => State.InsertCard(this);

    public void Ejectcard()
        => State.EjectCard(this);

    public void SetPassword()
        => State.SetPassword();
    
    public void WithDraw()
        => State.WithDraw();
    
}