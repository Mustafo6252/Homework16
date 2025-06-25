namespace Homework16;

public class Person
{
    public int age;
    public void Greet()
    {
        Console.WriteLine("Hello !");
    }

    public void SetAge(int age)
    {
        this.age= age;
    }

    public int GetAge()
    {
        return this.age;
    }
}