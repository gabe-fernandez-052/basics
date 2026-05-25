using DesignPatterns.Behavioral.Memento.Memento;

namespace DesignPatterns.Behavioral.Memento.Originator
{
    public class Graphic
    {
        private string _color;
        private (double X, double Y) _position;
        private double _width;

        public Graphic(string color, double x, double y, double width)
        {
            _color    = color;
            _position = (x, y);
            _width    = width;
        }

        public void Move(double dx, double dy)
        {
            _position = (_position.X + dx, _position.Y + dy);
            Console.WriteLine($"Graphic moved to ({_position.X}, {_position.Y})");
        }

        public void ChangeColor(string color)
        {
            _color = color;
            Console.WriteLine($"Graphic color changed to '{_color}'");
        }

        public GraphicMemento CreateMemento() =>
            new(_color, _position, _width);

        public void SetMemento(GraphicMemento memento)
        {
            _color    = memento.Color;
            _position = memento.Position;
            _width    = memento.Width;
            Console.WriteLine($"Graphic restored: color='{_color}', position=({_position.X}, {_position.Y})");
        }
    }
}
