using AbstractFactory.Furnitures.Interface;

namespace AbstractFactory.Furnitures.Victorian;
public class VictorianChair : IChair
{
    public bool hasLegs()
    {
        return true;
    }
    public void sitOn()
    {
        Console.WriteLine("Sitting on a victorian chair.");
    }

}
