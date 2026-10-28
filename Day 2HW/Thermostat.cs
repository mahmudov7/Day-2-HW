public class Thermostat
{
    public double Temperature{get;set;}
    public void TurnOn()
    {
        Console.WriteLine("Thermostat is turned on");
    }
    public void TurnOff()
    {
        Console.WriteLine("Thermostat is turned off");
    }
    public void SetTemperature(double t)
    {
        Temperature = t;
        Console.WriteLine($"Temperature set to {Temperature} *C");
    }
}