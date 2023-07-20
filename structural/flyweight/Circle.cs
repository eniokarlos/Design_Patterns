namespace flyweight;

public class Circle : IForm
{
    //extrinsic state
    public string? Color {get; set;}
    //intrinsic state (cache)
    private readonly int x = 10;
    private readonly int y = 20;
    private readonly int radius = 30;

    public void SetColor(string color)
    {
        this.Color = color;
    }

    public void Draw()
    {
        System.Console.WriteLine($"Circle: Draw() [Color: {Color}, x: {x}, y: {y}, radius: {radius}]");
    }
}