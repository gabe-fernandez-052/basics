using DesignPatterns.Behavioral.Command.Command;
using DesignPatterns.Behavioral.Command.Receiver;

namespace DesignPatterns.Behavioral.Command.Concrete
{
    public class PasteCommand(Document document) : ICommand
    {
        private readonly Document _document = document;

        public void Execute() => _document.Paste();
        public void Undo()    => Console.WriteLine($"PasteCommand: undoing paste in '{_document.Name}'.");
    }
}
