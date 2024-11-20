using DesignPatterns.Structural.Adapter.Adaptee;
using DesignPatterns.Structural.Adapter.Target;

namespace DesignPatterns.Structural.Adapter.Adapter
{
    public class TextShapeAdapter(TextView textView) : IShape
    {
        private readonly TextView _textView = textView;

        public void BoundingBox()
        {
            _textView.GetExtent(out int width, out int height);
            Console.WriteLine($"TextShapeAdapter: Bounding Box = Width: {width}, Height: {height}");
        }

        public void Draw()
        {
            _textView.DisplayText();
        }
    }
}