using DesignPatterns.Structural.Bridge.Implementor;

namespace DesignPatterns.Structural.Bridge.ConcreteImplementor
{
    public class WindowsRenderer : IWindowRenderer
    {
        public void DrawWindow(string title)
        {
            Console.WriteLine($"Drawing {title} window using Windows Renderer.");
        }

        public void DrawButton(string text)
        {
            Console.WriteLine($"Drawing button '{text}' using Windows Renderer.");
        }
    }
}