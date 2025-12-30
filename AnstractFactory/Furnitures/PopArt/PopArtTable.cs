using AbstractFactory.Furnitures.Interface;

namespace AbstractFactory.Furnitures.PopArt;
public class PopArtTable : ITable
{
    public void dineOn()
    {
       Console.WriteLine("Dining on a pop art table.");
    }

    public bool hasLegs()
    {
       return true;
    }
}
