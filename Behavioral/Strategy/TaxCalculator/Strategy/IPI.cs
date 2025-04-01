using Behavioral.Strategy.TaxCalculator.Strategy.Interface;

namespace Behavioral.Strategy.TaxCalculator.Strategy;

public class IPI : ITaxStrategy
{
  public decimal Calculate(decimal amount) => amount * 15 / 100;
}