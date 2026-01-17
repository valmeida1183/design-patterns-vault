using Observer.Interface;
using Observer.Publishers;

namespace Observer.Observers;
public class ConcreteObserverB : IObserver
{
    public void Update(IPublisher publisher)
    {
        if ((publisher as Publisher)?.State == 0 || (publisher as Publisher)?.State >= 2)
        {
            Console.WriteLine("ConcreteObserverB: Reacted to the event.");
        }
    }
}
