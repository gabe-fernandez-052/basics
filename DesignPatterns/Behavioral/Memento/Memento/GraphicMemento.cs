namespace DesignPatterns.Behavioral.Memento.Memento
{
    public class GraphicMemento
    {
        public string Color { get; }
        public (double X, double Y) Position { get; }
        public double Width { get; }

        internal GraphicMemento(string color, (double X, double Y) position, double width)
        {
            Color    = color;
            Position = position;
            Width    = width;
        }
    }
}
