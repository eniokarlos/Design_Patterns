namespace proxy;

public class MathProxy : IMath
{
    private Math math = new Math();

    public double Add(double x, double y) => math.Add(x,y);
    public double Sub(double x, double y) => math.Sub(x,y);
    public double Mul(double x, double y) => math.Mul(x,y);
    public double Div(double x, double y) => math.Div(x,y);
}