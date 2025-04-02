namespace Structural.Facade.DTO;

public record OrderDetails(
  int productStockId,
  int quantity,
  decimal amount,
  string email,
  string userName,
  int addressId);