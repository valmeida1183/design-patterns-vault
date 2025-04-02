using Structural.Facade;
using Structural.Facade.DTO;
using Structural.Facade.Service;

// Em um cenário real todas as dependências seriam resolvidas via injeção de dependência.

var processPaymentService = new ProcessPaymentService();
var paymentConfirmationService = new PaymentConfirmationService();
var productStockService = new ProductStockService();
var shippingService = new ShippingService();

var facade = new OrderFacade(
  processPaymentService,
  paymentConfirmationService,
  productStockService,
  shippingService);

var orderDetail = new OrderDetails(1234, 1, 10M, "teste@email.com", "testUser", 335);

facade.ProcessOrders(orderDetail);
