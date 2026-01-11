using FactoryMethod.Logistics;
namespace FactoryMethod;

// The consumer of the Factory Method pattern
public class LogistcClient
{
    private readonly LogisticCreator _logistic;

    public LogistcClient(LogisticCreator logistic)
    {
        _logistic = logistic;
    }

    public void Run()
    {
        var transport = _logistic.CreateTransport();
        transport.Deliver();
    }    
}
