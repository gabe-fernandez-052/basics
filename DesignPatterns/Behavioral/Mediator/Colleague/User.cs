using DesignPatterns.Behavioral.Mediator.Mediator;

namespace DesignPatterns.Behavioral.Mediator.Colleague
{
    public class User(string name, IMediator mediator) : Colleague(name, mediator)
    {
        public override void Send(string message)
        {
            Console.WriteLine($"{Name} sends: {message}");
            Mediator.SendMessage(message, Name);
        }

        public override void Receive(string message)
        {
            Console.WriteLine($"  {Name} receives: {message}");
        }
    }
}
