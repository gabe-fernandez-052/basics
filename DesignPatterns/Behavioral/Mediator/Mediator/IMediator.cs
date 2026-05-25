namespace DesignPatterns.Behavioral.Mediator.Mediator
{
    public interface IMediator
    {
        void SendMessage(string message, string senderName);
    }
}
