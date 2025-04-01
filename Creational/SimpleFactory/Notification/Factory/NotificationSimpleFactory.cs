
using Creational.SimpleFactory.Notification.Enum;
using Creational.SimpleFactory.Notification.Interface;

namespace Creational.SimpleFactory.Notification;
public class NotificationSimpleFactory
{
  public static INotification Create(NotificationTypeEnum notificationType)
  {
    return notificationType switch
    {
      NotificationTypeEnum.Email => new EmailNotification(),
      NotificationTypeEnum.Sms => new SmsNotification(),
      NotificationTypeEnum.Slack => new SlackNotification(),
      _ => throw new ArgumentException("Invalid notification type"),
    };
  }
}