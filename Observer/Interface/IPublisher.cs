namespace Observer.Interface;

public interface IPublisher
{
    void Attach(IObserver observer);
    void Detach(IObserver observer);
    void Notify();
}
