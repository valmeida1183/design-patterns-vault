using Creational.SimpleFactory.Notification.Interface;

namespace Creational.SimpleFactory.Notification;

public class SlackNotification : INotification
{
  public void Send(string message, string recipient)
  {
    Console.WriteLine($"SlackNotificationwas called with message: {message} by {recipient}");
  }
}