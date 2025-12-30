using AbstractFactory.Furnitures.Interface;

namespace AbstractFactory.Furnitures.Modern;
public class ModernTable : ITable
{
    public void dineOn()
    {
       Console.WriteLine("Dining on a modern table.");
    }

    public bool hasLegs()
    {
        return false;
    }
}
