using FactoryMethod.Transports.Interface;

namespace FactoryMethod.Logistics;

// Abstract Creator
public abstract class LogisticCreator
{
    // The factory method (This is the core of Factory method pattern)
    public abstract ITransport CreateTransport();

    public void PlanDelivery()
    {
        // Call the factory method to create a transport object
        ITransport transport = CreateTransport();
        // Use the created transport object
        transport.Deliver();
    }
}
