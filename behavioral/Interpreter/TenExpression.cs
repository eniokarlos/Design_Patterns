namespace Interpreter;

public class TenExpression : Expression
{
    private TenExpression(){}
    public static TenExpression Of() => new TenExpression();
    public override string One() => "X";
    public override string Four() => "XL";
    public override string Five() => "L";
    public override string Nine() => "XC";
    public override int Multiplier() => 10;
}