using AbstractFactory.Factories.Interface;
using AbstractFactory.Furnitures.Interface;
using AbstractFactory.Furnitures.PopArt;

namespace AbstractFactory.Factories;
public class PopArtFurnitureFactory : IFurnitureFactory
{
    public IChair CreateChair()
    {
       return new PopArtChair();
    }

    public ISofa CreateSofa()
    {
        return new PopArtSofa();
    }

    public ITable CreateTable()
    {
        return new PopArtTable();
    }
}
