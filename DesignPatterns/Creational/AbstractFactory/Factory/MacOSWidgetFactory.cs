using DesignPatterns.Creational.AbstractFactory.Products;

namespace DesignPatterns.Creational.AbstractFactory.Factory
{
    public class MacOSWidgetFactory : IWidgetFactory
    {
        public IButton CreateButton()
        {
            return new MacOSButton();
        }

        public IScrollbar CreateScrollbar()
        {
            return new MacOSScrollbar();
        }
    }
}