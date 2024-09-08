namespace DesignPatterns.Creational.AbstractFactory.Products
{
    public class MacOSButton : IButton
    {
        public void Paint() => Console.WriteLine("Rendering a button in a MacOS style.");
    }
}