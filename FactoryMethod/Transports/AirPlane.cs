using FactoryMethod.Transports.Interface;

namespace FactoryMethod.Transports;

// Concrete Product
public class AirPlane : ITransport
{
    public void Deliver()
    {
        Console.WriteLine("Deliver by air in an airplane.");
    }

}
