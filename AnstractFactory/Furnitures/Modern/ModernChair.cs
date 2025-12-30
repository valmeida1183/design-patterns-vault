using AbstractFactory.Furnitures.Interface;

namespace AbstractFactory.Furnitures.Modern;
public class ModernChair : IChair
{
    public bool hasLegs()
    {
        return false;
    }

    public void sitOn()
    {
        Console.WriteLine("Sitting on a modern chair.");
    }
}
