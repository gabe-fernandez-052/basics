using ColleagueBase = DesignPatterns.Behavioral.Mediator.Colleague.Colleague;

namespace DesignPatterns.Behavioral.Mediator.Mediator
{
    public class ChatRoom : IMediator
    {
        private readonly List<ColleagueBase> _colleagues = new();

        public void Register(ColleagueBase colleague) => _colleagues.Add(colleague);

        public void SendMessage(string message, string senderName)
        {
            foreach (var colleague in _colleagues.Where(c => c.Name != senderName))
                colleague.Receive(message);
        }
    }
}