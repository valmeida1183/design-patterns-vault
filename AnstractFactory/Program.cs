using AbstractFactory;
using AbstractFactory.Factories;
using AbstractFactory.Factories.Interface;

Console.WriteLine("Escolha um modelo de design de moveis:");
Console.WriteLine("0 Para Moderno");
Console.WriteLine("1 Para Pop Art");
Console.WriteLine("2 Para Vitoriano");

var modeloAtribuido = int.TryParse(Console.ReadLine(), out var modelo);
IFurnitureFactory factory;

if (modeloAtribuido)
{
    factory = modelo switch
    {
        0 => new ModernFurnitureFactory(),
        1 => new PopArtFurnitureFactory(),
        2 => new VictorianFurnitureFactory(),
        _ => throw new ArgumentException("Invalid Model"),
    };

    var furnitureClient = new FurnitureClientContext(factory);
    furnitureClient.Run();
}

Console.ReadLine();