using FactoryMethod.Transports.Interface;

namespace FactoryMethod.Transports;

// Concrete Product
public class Truck : ITransport
{
    public void Deliver()
    {
        Console.WriteLine("Deliver by land in a truck.");
    }
}
