using flyweight;

System.Console.WriteLine("Yellow Circles ");
for(int i = 0; i < 3; i++)
{
    var circle = (Circle)FormFactory.GetForm("Circle");
    circle.SetColor("yellow");
    circle.Draw();
}

System.Console.WriteLine("Green Circle ");
for(int i = 0; i < 3; i++)
{
    var circle = (Circle)FormFactory.GetForm("Circle");
    circle.SetColor("green");
    circle.Draw();
}