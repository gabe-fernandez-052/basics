namespace DesignPatterns.Creational.AbstractFactory.Products
{
    public class WindowsButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("Rendering a button in a Windows style.");
        }
    }
}