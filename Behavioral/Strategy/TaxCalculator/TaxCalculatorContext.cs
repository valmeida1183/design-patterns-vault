using Behavioral.Strategy.TaxCalculator.Strategy.Interface;

namespace Behavioral.Strategy.TaxCalculator;

// Esse é o context
public class TaxCalculatorContext
{
  private ITaxStrategy _taxStrategy;

  public TaxCalculatorContext(ITaxStrategy taxStrategy)
  {
    _taxStrategy = taxStrategy;
  }

  public decimal Calculate(decimal amount)
  {
    return _taxStrategy.Calculate(amount);
  }

  public void SetStrategy(ITaxStrategy strategy)
  {
    _taxStrategy = strategy;
  }
}