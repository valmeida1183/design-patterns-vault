using Creational.SimpleFactory.Notification.Interface;

namespace Creational.SimpleFactory.Notification;

public class EmailNotification : INotification
{
  public void Send(string message, string recipient)
  {
    Console.WriteLine($"EmailNotification was called with message: {message} by {recipient}");
  }
}