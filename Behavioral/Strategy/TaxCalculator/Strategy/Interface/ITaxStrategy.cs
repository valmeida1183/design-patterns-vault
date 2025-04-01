namespace Behavioral.Strategy.TaxCalculator.Strategy.Interface;

public interface ITaxStrategy
{
  decimal Calculate(decimal amount);
}