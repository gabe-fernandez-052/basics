using DesignPatterns.Behavioral.Command.Concrete;
using DesignPatterns.Behavioral.Command.Invoker;
using DesignPatterns.Behavioral.Command.Receiver;

namespace DesignPatterns.Behavioral.Command
{
    /// <summary>
    /// What is it?
    /// Encapsulate a request as an object, thereby letting you parameterize clients with different requests,
    /// queue or log requests, and support undoable operations.
    /// When to use?
    /// You want to parameterize objects by the action to perform.
    /// You want to specify, queue, and execute requests at different times.
    /// You need to support undo operations.
    /// You need to support logging changes so they can be reapplied in case of a system crash.
    /// You want to structure a system around high-level operations built on primitive operations.
    /// </summary>
    public class Client
    {
        public void Run()
        {
            var application = new Application();

            var openItem = new MenuItem("Open", new OpenCommand(application));
            openItem.Clicked();

            Console.WriteLine();

            var doc       = application.LastDocument!;
            var pasteCmd  = new PasteCommand(doc);
            var pasteItem = new MenuItem("Paste", pasteCmd);
            pasteItem.Clicked();

            Console.WriteLine();
            Console.WriteLine("Undo paste:");
            pasteCmd.Undo();
        }
    }
}
