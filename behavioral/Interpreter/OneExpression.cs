namespace Interpreter;

public class OneExpression : Expression
{
    private OneExpression(){}
    public static OneExpression Of() => new OneExpression();
    public override string One() => "I"; 
    public override string Four() => "IV"; 
    public override string Five() => "V"; 
    public override string Nine() => "IX"; 
    public override int Multiplier() => 1; 
}