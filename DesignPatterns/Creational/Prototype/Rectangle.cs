namespace DesignPatterns.Creational.Prototype
{
    public class Rectangle : IPrototype
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public IPrototype Clone()
        {
            return new Rectangle(this.Width, this.Height);
        }

        public override string ToString()
        {
            return $"Rectangle with width {Width} and height {Height}";
        }
    }
}