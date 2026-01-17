using Observer.Interface;
using Observer.Publishers;

namespace Observer.Observers;

// Concrete Subscriber
public class ConcreteObserverA : IObserver
{
    public void Update(IPublisher publisher)
    {
        if ((publisher as Publisher)?.State < 3)
        {
            Console.WriteLine("ConcreteObserverA: Reacted to the event.");
        }
    }
}
