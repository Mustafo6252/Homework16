namespace Homework16;

public class Student:Person
{
    public void Study()
    {
        Console.WriteLine("I am studying");
    }

    public void ShowAge()
    {
        Console.WriteLine($"My age is {GetAge()} years old ");
    }
}