using Creational.SimpleFactory.Notification;
using Creational.SimpleFactory.Notification.Enum;

var emailNotification = NotificationSimpleFactory.Create(NotificationTypeEnum.Email);

emailNotification.Send("This is the test message", "Vinicius");

var SmsNotification = NotificationSimpleFactory.Create(NotificationTypeEnum.Sms);

SmsNotification.Send("This is the test message", "Maria");

var SlackNotification = NotificationSimpleFactory.Create(NotificationTypeEnum.Slack);

SlackNotification.Send("This is the test message", "Pedro");