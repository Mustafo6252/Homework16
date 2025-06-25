namespace Homework16;

public class Rectangle:Shape
{
    private double width;
    private double height;

    public Rectangle(string color, double width, double height) : base(color)
    {
        this.width = width;
        this.height = height;
    }

    public double Area()
    {
        return width * height;
    }

    public void GetInfo()
    {
        Console.WriteLine(
            $"""
            width:   {width}
            height:  {height}
            area:    {Area()}
            """
            );
    }
}