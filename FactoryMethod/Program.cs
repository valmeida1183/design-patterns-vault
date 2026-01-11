using FactoryMethod;
using FactoryMethod.Logistics;

Console.WriteLine("Escolha um modelo de logística:");
Console.WriteLine("0 Para terrestre");
Console.WriteLine("1 Para marítmo");
Console.WriteLine("2 Para aéreo");

var modeloAtribuido = int.TryParse(Console.ReadLine(), out var modelo);

LogisticCreator creator;

if (modeloAtribuido)
{
    creator = modelo switch
    {
        0 => new RoadLogistics(),
        1 => new SeaLogistics(),
        2 => new AirLogistics(),
        _ => throw new ArgumentException("Invalid Model"),
    };

    var logisticClient = new LogistcClient(creator);
    logisticClient.Run();
}

Console.ReadLine();
