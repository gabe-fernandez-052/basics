using DesignPatterns.Creational.AbstractFactory.Products;

namespace DesignPatterns.Creational.AbstractFactory.Factory
{
    public class WindowsWidgetFactory : IWidgetFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }

        public IScrollbar CreateScrollbar()
        {
            return new WindowsScrollbar();
        }
    }
}