using DesignPatterns.Structural.Bridge.Abstraction;
using DesignPatterns.Structural.Bridge.Implementor;

namespace DesignPatterns.Structural.Bridge.RefinedAbstraction
{
    public class IconWindow(IWindowRenderer renderer) : Window(renderer)
    {
        public override void Draw()
        {
            renderer.DrawWindow("Icon");
        }
    }
}