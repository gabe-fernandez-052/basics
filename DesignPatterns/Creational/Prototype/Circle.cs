namespace DesignPatterns.Creational.Prototype
{
    public class Circle : IPrototype
    {
        public int Radius { get; set; }

        public Circle(int radius)
        {
            Radius = radius;
        }

        public IPrototype Clone()
        {
            return new Circle(this.Radius);
        }

        public override string ToString()
        {
            return $"Circle with radius {Radius}";
        }
    }
}