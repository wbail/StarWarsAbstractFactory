public abstract class Ship
{
    public virtual void Shoot(string weapon)
    {
        Console.WriteLine($"Shooting {weapon}!");
    }

    public virtual void RaiseShields()
    {
        Console.WriteLine($"Shields Raised!");
    }
}