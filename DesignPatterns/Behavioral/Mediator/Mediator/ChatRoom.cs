using DesignPatterns.Behavioral.Mediator.Colleague;

namespace DesignPatterns.Behavioral.Mediator.Mediator
{
    public class ChatRoom : IMediator
    {
        private readonly List<Colleague> _colleagues = new();

        public void Register(Colleague colleague) => _colleagues.Add(colleague);

        public void SendMessage(string message, string senderName)
        {
            foreach (var colleague in _colleagues.Where(c => c.Name != senderName))
                colleague.Receive(message);
        }
    }
}
