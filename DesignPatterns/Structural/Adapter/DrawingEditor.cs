using DesignPatterns.Structural.Adapter.Target;

namespace DesignPatterns.Structural.Adapter
{
    public class DrawingEditor
    {
        private readonly List<IShape> _shapes = [];

        public void AddShape(IShape shape)
        {
            _shapes.Add(shape);
        }

        public void Render()
        {
            foreach (var shape in _shapes)
            {
                shape.BoundingBox();
                shape.Draw();
            }
        }
    }
}