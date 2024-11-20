using DesignPatterns.Structural.Decorator.Component;

namespace DesignPatterns.Structural.Decorator.Decorator
{
    public abstract class CondimentDecorator(Beverage beverage) : Beverage
    {
        protected Beverage Beverage = beverage;

        public override string GetDescription() => Beverage.GetDescription();

        public override double Cost() => Beverage.Cost();
    }
}