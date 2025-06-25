namespace Homework16;

public class Thermostat:IDevice
{

    public void TurnOff()
    {
        Console.WriteLine("Thermostat is Turning Off");
    }

    public void TurnOn()
    {
        Console.WriteLine("Thermostat is Turning On");
    }

}