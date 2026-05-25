using DesignPatterns.Behavioral.Command.Command;
using DesignPatterns.Behavioral.Command.Receiver;

namespace DesignPatterns.Behavioral.Command.Concrete
{
    public class InsertTextCommand(TextEditor editor, string text) : ICommand
    {
        private readonly TextEditor _editor = editor;
        private readonly string _text = text;

        public void Execute() => _editor.InsertText(_text);
        public void Undo() => _editor.DeleteText(_text);
    }
}
