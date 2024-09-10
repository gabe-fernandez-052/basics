namespace DesignPatterns.Creational.Prototype
{
    public class Circle(int radius) : IPrototype
    {
        public int Radius { get; set; } = radius;

        public IPrototype Clone() => new Circle(Radius);

        public override string ToString() => $"Circle with radius {Radius}";
    }
}