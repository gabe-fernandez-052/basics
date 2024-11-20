using DesignPatterns.Structural.Decorator.Component;

namespace DesignPatterns.Structural.Decorator.ConcreteComponent
{
    public class Espresso : Beverage
    {
        public override string GetDescription() => "Espresso";

        public override double Cost() => 1.99;
    }
}