using DesignPatterns.Behavioral.Memento.Memento;
using DesignPatterns.Behavioral.Memento.Originator;

namespace DesignPatterns.Behavioral.Memento.Caretaker
{
    public class MoveCommand
    {
        private readonly Graphic _graphic;
        private readonly double _dx;
        private readonly double _dy;
        private GraphicMemento? _snapshot;

        public MoveCommand(Graphic graphic, double dx, double dy)
        {
            _graphic = graphic;
            _dx      = dx;
            _dy      = dy;
        }

        public void Execute()
        {
            _snapshot = _graphic.CreateMemento();
            _graphic.Move(_dx, _dy);
        }

        public void Undo()
        {
            if (_snapshot != null)
                _graphic.SetMemento(_snapshot);
        }
    }
}
