using DesignPatterns.Creational.AbstractFactory.Products;

namespace DesignPatterns.Creational.AbstractFactory.Factory
{
    internal interface IWidgetFactory
    {
        IButton CreateButton();

        IScrollbar CreateScrollbar();
    }
}