using DesignPatterns.Creational.AbstractFactory.Products;

public class WindowsScrollbar : IScrollbar
{
    public void Scroll() => Console.WriteLine("Scrolling with a Windows-style scrollbar.");
}