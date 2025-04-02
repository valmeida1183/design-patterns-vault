namespace Structural.Facade.Service;

using Structural.Facade.Service.Interface;

public class ShippingService : IService
{
  public void InitiateShipping(int addressId)
  {
    Console.WriteLine($"The product shipping was started to this address Id: {addressId}");
  }
}