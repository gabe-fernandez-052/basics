using DesignPatterns.Structural.Bridge.Implementor;

namespace DesignPatterns.Structural.Bridge.ConcreteImplementor
{
    public class LinuxRenderer : IWindowRenderer
    {
        public void DrawWindow(string title)
        {
            Console.WriteLine($"Drawing {title} window using Linux Renderer.");
        }

        public void DrawButton(string text)
        {
            Console.WriteLine($"Drawing button '{text}' using Linux Renderer.");
        }
    }
}
