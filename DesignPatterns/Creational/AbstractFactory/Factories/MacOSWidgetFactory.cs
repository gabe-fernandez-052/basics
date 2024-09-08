using DesignPatterns.Creational.AbstractFactory.Products;

namespace DesignPatterns.Creational.AbstractFactory.Factories
{
    public class MacOSWidgetFactory : IWidgetFactory
    {
        public IButton CreateButton() => new MacOSButton();

        public IScrollbar CreateScrollbar() => new MacOSScrollbar();
    }
}