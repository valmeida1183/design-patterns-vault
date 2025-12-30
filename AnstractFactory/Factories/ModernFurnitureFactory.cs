using AbstractFactory.Factories.Interface;
using AbstractFactory.Furnitures.Interface;
using AbstractFactory.Furnitures.Modern;

namespace AbstractFactory.Factories;
public class ModernFurnitureFactory : IFurnitureFactory
{
    public IChair CreateChair()
    {
        return new ModernChair();
    }

    public ISofa CreateSofa()
    {
        return new ModernSofa();
    }

    public ITable CreateTable()
    {
        return new ModernTable();
    }
}
