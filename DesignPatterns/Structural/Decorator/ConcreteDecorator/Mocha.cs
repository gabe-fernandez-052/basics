using DesignPatterns.Structural.Decorator.Component;
using DesignPatterns.Structural.Decorator.Decorator;

namespace DesignPatterns.Structural.Decorator.ConcreteDecorator
{
    public class Mocha(Beverage beverage) : CondimentDecorator(beverage)
    {
        public override string GetDescription() => Beverage.GetDescription() + ", Mocha";

        public override double Cost() => Beverage.Cost() + 0.20;
    }
}