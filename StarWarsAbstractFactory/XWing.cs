public class XWing : Ship
{
    public override void Shoot(string weapon)
    {
        Console.WriteLine($"{nameof(XWing)} shooting {weapon}!");
    }

    public override void RaiseShields()
    {
        Console.WriteLine($"{nameof(XWing)} raised shields.");
    }
}