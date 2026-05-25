using DesignPatterns.Behavioral.Memento.Caretaker;
using DesignPatterns.Behavioral.Memento.Originator;

namespace DesignPatterns.Behavioral.Memento
{
    /// <summary>
    /// What is it?
    /// Without violating encapsulation, capture and externalize an object's internal state so that the object can be restored to this state later.
    /// When to use?
    /// A snapshot of an object's state must be saved so that it can be restored to that state later.
    /// A direct interface to obtaining the state would expose implementation details and break the object's encapsulation.
    /// </summary>
    public class Client
    {
        public void Run()
        {
            var editor = new TextEditor();
            var history = new EditorHistory();

            editor.SetContent("Hello");
            history.Save(editor.Save());
            Console.WriteLine($"Content: {editor.Content}");

            editor.SetContent("Hello World");
            history.Save(editor.Save());
            Console.WriteLine($"Content: {editor.Content}");

            editor.SetContent("Hello World!");
            Console.WriteLine($"Content: {editor.Content}");

            Console.WriteLine("\nUndoing...");
            editor.Restore(history.Undo());
            Console.WriteLine($"Content: {editor.Content}");

            Console.WriteLine("\nUndoing again...");
            editor.Restore(history.Undo());
            Console.WriteLine($"Content: {editor.Content}");
        }
    }
}
