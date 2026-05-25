using DesignPatterns.Behavioral.Command.Command;

namespace DesignPatterns.Behavioral.Command.Invoker
{
    public class CommandHistory
    {
        private readonly Stack<ICommand> _history = new();

        public void Execute(ICommand command)
        {
            command.Execute();
            _history.Push(command);
        }

        public void Undo()
        {
            if (_history.TryPop(out var command))
                command.Undo();
            else
                Console.WriteLine("Nothing to undo.");
        }
    }
}
