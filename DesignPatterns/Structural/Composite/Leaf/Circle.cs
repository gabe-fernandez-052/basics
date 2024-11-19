using DesignPatterns.Structural.Composite.Component;

namespace DesignPatterns.Structural.Composite.Leaf
{
    public class Circle : Graphic
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Circle");
        }
    }
}
