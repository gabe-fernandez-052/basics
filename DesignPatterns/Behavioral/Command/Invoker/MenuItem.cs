using DesignPatterns.Behavioral.Command.Command;

namespace DesignPatterns.Behavioral.Command.Invoker
{
    public class MenuItem(string name, ICommand command)
    {
        private readonly string _name = name;
        private readonly ICommand _command = command;

        public void Clicked()
        {
            Console.WriteLine($"MenuItem '{_name}' clicked.");
            _command.Execute();
        }
    }
}
