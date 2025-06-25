namespace Homework16;

public class Lamp:IDevice
{
    
    public void TurnOff()
    {
        Console.WriteLine("Lamp is Turning Off");
    }

    public void TurnOn()
    {
        Console.WriteLine("Lamp is Turning On");
    }
}