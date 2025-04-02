namespace Structural.Facade.Service;

using Structural.Facade.Service.Interface;

public class ProductStockService : IService
{
  public void UpdateProductStock(int productStockId, int quantity)
  {
    Console.WriteLine($"Product with Id: {productStockId} was updated to quantity: {quantity}");
  }
}