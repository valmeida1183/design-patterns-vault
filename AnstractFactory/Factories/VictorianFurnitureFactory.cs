using AbstractFactory.Factories.Interface;
using AbstractFactory.Furnitures.Interface;
using AbstractFactory.Furnitures.Victorian;

namespace AbstractFactory.Factories;
public class VictorianFurnitureFactory : IFurnitureFactory
{
    public IChair CreateChair()
    {
        return new VictorianChair();
    }

    public ISofa CreateSofa()
    {
       return new VictorianSofa();
    }

    public ITable CreateTable()
    {
       return new VictorianTable();
    }
}
