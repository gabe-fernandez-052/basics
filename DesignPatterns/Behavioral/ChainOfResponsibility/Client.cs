using DesignPatterns.Behavioral.ChainOfResponsibility.Concrete;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    /// <summary>
    /// What is it?
    /// Avoid coupling the sender of a request to its receiver by giving more than one object a chance to handle the request.
    /// Chain the receiving objects and pass the request along the chain until an object handles it.
    /// When to use?
    /// More than one object may handle a request, and the handler isn't known a priori. The handler should be ascertained automatically.
    /// You want to issue a request to one of several objects without specifying the receiver explicitly.
    /// The set of objects that can handle a request should be specified dynamically.
    /// </summary>
    public class Client
    {
        public void Run()
        {
            var application  = new HelpApplication("Application Help");
            var dialog       = new Dialog(application, "Print Dialog", "Paper Sizes");
            var printButton  = new Button(dialog, "Print");
            var cancelButton = new Button(dialog, "Cancel", "Canceling a Print Job");

            Console.WriteLine("Print button requests help (no topic — passes up to dialog):");
            printButton.HandleHelp();

            Console.WriteLine();
            Console.WriteLine("Cancel button requests help (has topic — handled directly):");
            cancelButton.HandleHelp();
        }
    }
}
