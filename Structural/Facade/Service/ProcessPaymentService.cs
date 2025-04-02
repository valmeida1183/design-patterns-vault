namespace Structural.Facade.Service;

using Structural.Facade.Service.Interface;

public class ProcessPaymentService : IService
{
  public void ProcessPayment(decimal amount)
  {
    Console.WriteLine($"Payment was processed with value: {amount}");
  }
}