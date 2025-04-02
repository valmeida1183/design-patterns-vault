namespace Structural.Facade.Service;

using Structural.Facade.Service.Interface;

public class PaymentConfirmationService : IService
{
  public void SendPaymentConfirmation(string email)
  {
    Console.WriteLine($"An email was sended to: {email}");
  }
}