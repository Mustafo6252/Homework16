namespace Homework16;

public class Circle:Shape
{
    private double radius;
    

    public Circle(string color, double radius) : base(color)
    {
        this.radius = radius;
    }

    public double Area()
    {
        return Math.PI * radius * radius;
    }

    public void GetInfo()
    {
        Console.WriteLine(
            $"""
            radius:   {radius}
            area:   {Area()}
            """
        );
    }
}