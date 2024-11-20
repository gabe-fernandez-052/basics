using DesignPatterns.Structural.Decorator.Component;
using DesignPatterns.Structural.Decorator.ConcreteComponent;
using DesignPatterns.Structural.Decorator.ConcreteDecorator;

namespace DesignPatterns.Structural.Decorator
{
    /// <summary>
    /// What is it?
    /// Attach additional responsibilities to an object dynamically. Decorators provide a flexible alternative to subclassing for extending functionality
    /// When to use?
    /// To add responsibilities to individual objects dynamically and transparantly, that is, without affecting other objects
    /// For responsibilities that can be withdrawan
    /// When extension by subclassing is impractical. Sometimes a large number of independent extensions are possible and would produce an explosion
    /// of subclasses to support every combination. Or a class definition may be hidden or otherwise unavailable for subclassing
    /// </summary>
    public class Client
    {
        public void Run()
        {
            Beverage beverage = new Espresso();
            beverage = new Mocha(beverage);
            beverage = new Milk(beverage);

            Console.WriteLine($"{beverage.GetDescription()} costs ${beverage.Cost():0.00}");

            Beverage houseBlend = new HouseBlend();
            houseBlend = new Milk(houseBlend);
            houseBlend = new Sugar(houseBlend);

            Console.WriteLine($"{houseBlend.GetDescription()} costs ${houseBlend.Cost():0.00}");
        }
    }
}