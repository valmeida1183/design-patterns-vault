using Observer.Observers;
using Observer.Publishers;

var publisher = new Publisher();
var observerA = new ConcreteObserverA();
var observerB = new ConcreteObserverB();

publisher.Attach(observerA);
publisher.Attach(observerB);

publisher.SomeBusinessLogic();
publisher.SomeBusinessLogic();

publisher.Detach(observerB);

publisher.SomeBusinessLogic();