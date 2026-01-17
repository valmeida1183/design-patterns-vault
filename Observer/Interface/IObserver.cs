namespace Observer.Interface;

public interface IObserver
{
    void Update(IPublisher publisher);
}
