namespace DesignPatterns.Creational.AbstractFactory.Products
{
    public class MacOSScrollbar : IScrollbar
    {
        public void Scroll()
        {
            Console.WriteLine("Scrolling with a MacOS-style scrollbar.");
        }
    }
}