namespace DesignPatterns.Creational.Prototype
{
    public class Rectangle(int width, int height) : IPrototype
    {
        public int Width { get; set; } = width;
        public int Height { get; set; } = height;

        public IPrototype Clone() => new Rectangle(Width, Height);

        public override string ToString() => $"Rectangle with width {Width} and height {Height}";
    }
}