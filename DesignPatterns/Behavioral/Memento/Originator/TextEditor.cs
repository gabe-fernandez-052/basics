using DesignPatterns.Behavioral.Memento.Memento;

namespace DesignPatterns.Behavioral.Memento.Originator
{
    public class TextEditor
    {
        public string Content { get; private set; } = string.Empty;

        public void SetContent(string content) => Content = content;

        public EditorMemento Save() => new(Content);

        public void Restore(EditorMemento memento) => Content = memento.Content;
    }
}
