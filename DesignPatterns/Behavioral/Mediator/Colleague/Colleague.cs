using DesignPatterns.Behavioral.Mediator.Mediator;

namespace DesignPatterns.Behavioral.Mediator.Colleague
{
    public abstract class Colleague(string name, IMediator mediator)
    {
        public string Name { get; } = name;
        protected readonly IMediator Mediator = mediator;

        public abstract void Send(string message);
        public abstract void Receive(string message);
    }
}
