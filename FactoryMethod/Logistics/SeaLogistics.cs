using FactoryMethod.Transports;
using FactoryMethod.Transports.Interface;

namespace FactoryMethod.Logistics;

// Concrete Creator
public class SeaLogistics : LogisticCreator
{
    // Implementation of the factory method
    public override ITransport CreateTransport()
    {
        return new Ship();
    }
}
