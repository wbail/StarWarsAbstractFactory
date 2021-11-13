public class StarDestroyer : Ship
{
    public override void Shoot(string weapon)
    {
        Console.WriteLine($"{nameof(StarDestroyer)} shooting {weapon}!");
    }

    public override void RaiseShields()
    {
        Console.WriteLine($"{nameof(StarDestroyer)} raised shields.");
    }
}