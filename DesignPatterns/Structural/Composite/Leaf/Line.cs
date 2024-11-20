using DesignPatterns.Structural.Composite.Component;

namespace DesignPatterns.Structural.Composite.Leaf
{
    public class Line : Graphic
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Line");
        }
    }
}