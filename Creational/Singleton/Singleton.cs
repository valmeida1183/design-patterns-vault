namespace Creational.Singleton;

public sealed class Singleton
{
  private static Singleton? _instance;

  private Singleton() { }

  public static Singleton GetInstance()
  {
    if (_instance == null)
    {
      _instance = new Singleton();
    }

    return _instance;
  }

  public void DoSomething()
  {
    Console.WriteLine("Some execution method of singleton!");
  }
}