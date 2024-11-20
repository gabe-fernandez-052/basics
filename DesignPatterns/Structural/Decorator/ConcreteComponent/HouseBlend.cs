using DesignPatterns.Structural.Decorator.Component;

namespace DesignPatterns.Structural.Decorator.ConcreteComponent
{
    public class HouseBlend : Beverage
    {
        public override string GetDescription() => "House Blend Coffee";

        public override double Cost() => 0.89;
    }
}