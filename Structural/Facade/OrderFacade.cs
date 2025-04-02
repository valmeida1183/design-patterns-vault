using Structural.Facade.DTO;
using Structural.Facade.Service;
using Structural.Facade.Service.Interface;

namespace Structural.Facade;

public class OrderFacade
{
  private readonly ProcessPaymentService _processPaymentService;
  private readonly PaymentConfirmationService _paymentConfirmationService;
  private readonly ProductStockService _productStockService;
  private readonly ShippingService _shippingService;


  public OrderFacade(
    ProcessPaymentService processPaymentService,
    PaymentConfirmationService paymentConfirmationService,
    ProductStockService productStockService,
    ShippingService shippingService)
  {
    _processPaymentService = processPaymentService;
    _paymentConfirmationService = paymentConfirmationService;
    _productStockService = productStockService;
    _shippingService = shippingService;
  }

  public void ProcessOrders(OrderDetails order)
  {
    _processPaymentService.ProcessPayment(order.amount);
    _paymentConfirmationService.SendPaymentConfirmation(order.email);
    _productStockService.UpdateProductStock(order.productStockId, order.quantity);
    _shippingService.InitiateShipping(order.addressId);
  }
}