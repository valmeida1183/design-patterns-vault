using AbstractFactory.Furnitures.Interface;

namespace AbstractFactory.Factories.Interface;
public interface IFurnitureFactory
{
    public IChair CreateChair();
    public ISofa CreateSofa();
    public ITable CreateTable();
}
