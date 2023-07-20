namespace State;

public interface ICashMachineState
{
    void InsertCard(CashMachine context);
    void EjectCard(CashMachine context);
    void SetPassword();
    void WithDraw();  
}
