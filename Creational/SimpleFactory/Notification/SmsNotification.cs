using Creational.SimpleFactory.Notification.Interface;

namespace Creational.SimpleFactory.Notification;

public class SmsNotification : INotification
{
  public void Send(string message, string recipient)
  {
    Console.WriteLine($"SmsNotification was called with message: {message} by {recipient}");
  }
}