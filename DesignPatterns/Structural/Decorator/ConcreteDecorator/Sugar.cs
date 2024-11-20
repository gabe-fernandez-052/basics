using DesignPatterns.Structural.Decorator.Component;
using DesignPatterns.Structural.Decorator.Decorator;

namespace DesignPatterns.Structural.Decorator.ConcreteDecorator
{
    public class Sugar(Beverage beverage) : CondimentDecorator(beverage)
    {
        public override string GetDescription() => Beverage.GetDescription() + ", Sugar";

        public override double Cost() => Beverage.Cost() + 0.05;
    }
}