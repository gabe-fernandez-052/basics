using DesignPatterns.Creational.AbstractFactory.Products;

namespace DesignPatterns.Creational.AbstractFactory.Factories
{
    internal interface IWidgetFactory
    {
        IButton CreateButton();

        IScrollbar CreateScrollbar();
    }
}