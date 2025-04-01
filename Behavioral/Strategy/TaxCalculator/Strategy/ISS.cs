using Behavioral.Strategy.TaxCalculator.Strategy.Interface;

namespace Behavioral.Strategy.TaxCalculator.Strategy;

public class ISS : ITaxStrategy
{
  public decimal Calculate(decimal amount) => amount * 11 / 100;
}