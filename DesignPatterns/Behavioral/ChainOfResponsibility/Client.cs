using DesignPatterns.Behavioral.ChainOfResponsibility.Concrete;
using DesignPatterns.Behavioral.ChainOfResponsibility.Handler;

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
            var teamLead = new TeamLeadHandler();
            var manager = new ManagerHandler();
            var director = new DirectorHandler();

            teamLead.SetNext(manager);
            manager.SetNext(director);

            Console.WriteLine("Submitting expense of $300:");
            teamLead.Handle(300);

            Console.WriteLine("\nSubmitting expense of $1500:");
            teamLead.Handle(1500);

            Console.WriteLine("\nSubmitting expense of $8000:");
            teamLead.Handle(8000);

            Console.WriteLine("\nSubmitting expense of $15000:");
            teamLead.Handle(15000);
        }
    }
}
