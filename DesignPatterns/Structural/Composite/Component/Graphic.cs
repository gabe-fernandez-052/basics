namespace DesignPatterns.Structural.Composite.Component
{
    public abstract class Graphic
    {
        public abstract void Draw();

        public virtual void Add(Graphic graphic) { throw new NotImplementedException(); }

        public virtual void Remove(Graphic graphic) { throw new NotImplementedException(); }

        public virtual Graphic GetChild(int index) { throw new NotImplementedException(); }
    }
}
