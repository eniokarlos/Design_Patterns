using Interpreter;

string roman = Console.ReadLine() ?? "";
roman.ToUpper();
Context context = new Context(roman);

List<Expression> tree = new List<Expression>();
tree.Add(ThousandExpression.Of());
tree.Add(HundredExpression.Of());
tree.Add(TenExpression.Of());
tree.Add(OneExpression.Of());


foreach(Expression exp in tree)
{
    exp.Interpret(context);
}

System.Console.WriteLine("{0} = {1}", roman, context.Output);

