using DesignPatterns.Creational.AbstractFactory.Products;

namespace DesignPatterns.Creational.AbstractFactory.Factories
{
    public class WindowsWidgetFactory : IWidgetFactory
    {
        public IButton CreateButton() => new WindowsButton();

        public IScrollbar CreateScrollbar() => new WindowsScrollbar();
    }
}