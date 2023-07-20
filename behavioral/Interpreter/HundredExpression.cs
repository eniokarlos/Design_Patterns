namespace Interpreter;

public class HundredExpression : Expression
{
    private HundredExpression(){}
    public static HundredExpression Of() => new HundredExpression();
    public override string One() => "C";
    public override string Four() => "CD";
    public override string Five() => "D";
    public override string Nine() => "CM";
    public override int Multiplier() => 100;
}