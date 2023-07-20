
namespace Interpreter;

public class ThousandExpression : Expression
{
    private ThousandExpression(){}
    public static ThousandExpression Of() => new ThousandExpression();
    
    public override string One() => "M";
    public override string Four() => " ";
    public override string Five() => " ";
    public override string Nine() => " ";
    public override int Multiplier() => 1000;
}