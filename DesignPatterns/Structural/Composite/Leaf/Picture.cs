using DesignPatterns.Structural.Composite.Component;

namespace DesignPatterns.Structural.Composite.Leaf
{
    public class Picture : Graphic
    {
        private readonly List<Graphic> _children = new();

        public override void Draw()
        {
            foreach (var child in _children)
            {
                child.Draw();
            }
        }

        public override void Add(Graphic graphic)
        {
            _children.Add(graphic);
        }

        public override void Remove(Graphic graphic)
        {
            _children.Remove(graphic);
        }

        public override Graphic GetChild(int index)
        {
            return _children[index];
        }
    }
}
