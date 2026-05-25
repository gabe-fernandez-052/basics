namespace DesignPatterns.Behavioral.Memento.Memento
{
    public class EditorMemento(string content)
    {
        public string Content { get; } = content;
    }
}
