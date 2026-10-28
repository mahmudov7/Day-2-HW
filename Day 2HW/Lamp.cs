public class Lamp : IDevice
{
    public int Brigtness{get;set;}
    public void TurnOn()
    {
        System.Console.WriteLine("Lamp is turned on");
    }
    public void TurnOff()
    {
        System.Console.WriteLine("Lamp is turned off");
    }
    public void BrightnessLevel(int a)
    {
    Brigtness = a;

        if (a > 100)
        {
            System.Console.WriteLine("Very bright");
        }
        else
        {
            System.Console.WriteLine("Not too brigth");
        }
    }

}