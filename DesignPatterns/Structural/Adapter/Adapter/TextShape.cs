using DesignPatterns.Structural.Adapter.Adaptee;
using DesignPatterns.Structural.Adapter.Target;

namespace DesignPatterns.Structural.Adapter.Adapter
{
    public class TextShapeAdapter : IShape
    {
        private readonly TextView _textView;

        public TextShapeAdapter(TextView textView)
        {
            _textView = textView;
        }

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