using DesignPatterns.Behavioral.Command.Command;
using DesignPatterns.Behavioral.Command.Receiver;

namespace DesignPatterns.Behavioral.Command.Concrete
{
    public class OpenCommand(Application application) : ICommand
    {
        private readonly Application _application = application;

        public void Execute()
        {
            var name = PromptForName();
            _application.NewDocument(name);
            _application.LastDocument?.Open();
        }

        public void Undo() => Console.WriteLine("OpenCommand: undo not supported.");

        private static string PromptForName()
        {
            Console.WriteLine("OpenCommand: prompting user for document name...");
            return "Report.txt";
        }
    }
}
