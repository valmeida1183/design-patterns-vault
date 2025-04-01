namespace Creational.SimpleFactory.Notification.Interface;

public interface INotification
{
  void Send(string message, string recipient);
}