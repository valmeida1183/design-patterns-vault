using AbstractFactory.Furnitures.Interface;

namespace AbstractFactory.Furnitures.Victorian;
public class VictorianSofa : ISofa
{
    public bool hasCushions()
    {
        return true;
    }
    public void lieOn()
    {
        Console.WriteLine("Lying on a victorian sofa.");
    }

}
