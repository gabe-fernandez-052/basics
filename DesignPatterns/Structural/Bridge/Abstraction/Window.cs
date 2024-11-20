using DesignPatterns.Structural.Bridge.Implementor;

namespace DesignPatterns.Structural.Bridge.Abstraction
{
    public abstract class Window(IWindowRenderer renderer)
    {
        protected IWindowRenderer _renderer = renderer;

        public abstract void Draw();
    }
}