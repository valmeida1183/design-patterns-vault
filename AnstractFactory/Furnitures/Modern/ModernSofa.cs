using AbstractFactory.Furnitures.Interface;

namespace AbstractFactory.Furnitures.Modern;
public class ModernSofa : ISofa
{
    public bool hasCushions()
    {
        return false;
    }

    public void lieOn()
    {
        Console.WriteLine("Lying on a modern sofa.");
    }
}
