public class ShipConcreteFactory : ShipAbstractFactory
{
    public override Ship CreateStarDestroyer()
    {
        return new StarDestroyer();
    }

    public override Ship CreateXWing()
    {
        return new XWing();
    }
}