namespace FactoryMethod.Transports;

// Concrete Product
public class Ship : Interface.ITransport
{
    public void Deliver()
    {
        Console.WriteLine("Deliver by sea in a ship.");
    }
}
