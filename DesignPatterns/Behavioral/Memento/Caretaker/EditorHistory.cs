using DesignPatterns.Behavioral.Memento.Memento;

namespace DesignPatterns.Behavioral.Memento.Caretaker
{
    public class EditorHistory
    {
        private readonly Stack<EditorMemento> _history = new();

        public void Save(EditorMemento memento) => _history.Push(memento);

        public EditorMemento Undo()
        {
            if (_history.TryPop(out var memento))
                return memento;

            throw new InvalidOperationException("No history to undo.");
        }
    }
}
