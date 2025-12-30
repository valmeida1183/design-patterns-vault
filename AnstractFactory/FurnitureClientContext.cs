using AbstractFactory.Factories.Interface;

namespace AbstractFactory;
public class FurnitureClientContext
{
    private readonly IFurnitureFactory _furnitureFactory;
    public FurnitureClientContext(IFurnitureFactory furnitureFactory)
    {
        _furnitureFactory = furnitureFactory;
    }
    public void Run()
    {
        var chair = _furnitureFactory.CreateChair();
        var table = _furnitureFactory.CreateTable();
        var sofa = _furnitureFactory.CreateSofa();
        
        chair.sitOn();
        Console.WriteLine($"Chair has legs: {chair.hasLegs()}");
        table.dineOn();
        Console.WriteLine($"Table has legs: {table.hasLegs()}");
        sofa.lieOn();
        Console.WriteLine($"Sofa has cushions: {sofa.hasCushions()}");
    }
}
