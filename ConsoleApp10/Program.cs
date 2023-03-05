public sealed class Shape
{
    public virtual void PrintName()
    {
        Console.WriteLine("Shape");
    }
}

public class Rectangle : Shape
{
    public override void PrintName()
    {
        Console.WriteLine("Rectangle");
    }
}

public class Triangle : Shape
{
    public new void PrintName()
    {
        Console.WriteLine("Triangle");
    }
}

public class Program
{
    public static void Main()
    {
        var shapes = new List<Shape>
        {
            new Rectangle(),
            new Triangle(),
            new Rectangle(),
            new Triangle(),
            new Shape()
        };

        foreach (var shape in shapes)
        {
            shape.PrintName();
        }
    }
}