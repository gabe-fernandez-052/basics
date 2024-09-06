using DesignPatterns.Creational.AbstractFactory.Factory;
using DesignPatterns.Creational.AbstractFactory.Products;

namespace DesignPatterns.Creational.AbstractFactory
{
    /// <summary>
    /// When to use?
    /// A system should be independent of how its products are created, composed, and represented.
    /// A system shpuld be configured with one of multiple families of products
    /// A family of related product objects is designed to be used together, and you need to enforce this constaint
    /// You want to provide a class library of products, and you want to reveal just their interfaces, not their implementation
    /// </summary>
    public class Client
    {
        public void Run()
        {
            // Create a Windows widget factory
            IWidgetFactory windowsFactory = new WindowsWidgetFactory();
            IButton windowsButton = windowsFactory.CreateButton();
            IScrollbar windowsScrollbar = windowsFactory.CreateScrollbar();

            windowsButton.Paint();
            windowsScrollbar.Scroll();

            // Create a MacOS widget factory
            IWidgetFactory macFactory = new MacOSWidgetFactory();
            IButton macButton = macFactory.CreateButton();
            IScrollbar macScrollbar = macFactory.CreateScrollbar();

            macButton.Paint();
            macScrollbar.Scroll();
        }
    }
}