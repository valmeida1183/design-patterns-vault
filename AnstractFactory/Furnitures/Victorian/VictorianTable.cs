using AbstractFactory.Furnitures.Interface;

namespace AbstractFactory.Furnitures.Victorian;
public class VictorianTable : ITable
{
    public void dineOn()
    {
       Console.WriteLine("Dining on a victorian table.");
    }
    public bool hasLegs()
    {
       return true;
    }   
{
}
