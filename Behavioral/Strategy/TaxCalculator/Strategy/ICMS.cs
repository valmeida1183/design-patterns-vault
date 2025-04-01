using Behavioral.Strategy.TaxCalculator.Strategy.Interface;

namespace Behavioral.Strategy.TaxCalculator.Strategy;

public class ICMS : ITaxStrategy
{
  public decimal Calculate(decimal amount) => amount * 4 / 100;
}