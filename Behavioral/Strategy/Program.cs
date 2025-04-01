
using Behavioral.Strategy.TaxCalculator;
using Behavioral.Strategy.TaxCalculator.Strategy;
using Behavioral.Strategy.TaxCalculator.Strategy.Interface;

Console.WriteLine("Escolha um dos impostos abaixo:");
Console.WriteLine("0 Para ICMS");
Console.WriteLine("1 Para IPI");
Console.WriteLine("2 Para ISS");

var impostoAtribuido = int.TryParse(Console.ReadLine(), out var imposto);
ITaxStrategy taxStrategy;

if (impostoAtribuido)
{

  // O Ideal é atribuir essa responsabilidade da lógica de Ifs/Switch para outro Design Pattern, o Simple Factory
  taxStrategy = imposto switch
  {
    0 => new ICMS(),
    1 => new IPI(),
    2 => new ISS(),
    _ => throw new ArgumentException("Invalid Tax"),
  };
  var tax = new TaxCalculatorContext(taxStrategy).Calculate(5000);
  Console.WriteLine($"The calculate tax is: {tax}");
}
else
{
  throw new ArgumentException("Invalid Tax");
}