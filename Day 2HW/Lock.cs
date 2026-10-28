public class Lock : IDevice
{
    public void TurnOff()
    {
        Console.WriteLine("Door is loked");
    }

    public void TurnOn()
    {
        System.Console.WriteLine("Door is unlocked");
    }
}