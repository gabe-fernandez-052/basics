using DesignPatterns.Behavioral.Observer.Observer;

namespace DesignPatterns.Behavioral.Observer.Subject
{
    public interface ISubject
    {
        void Subscribe(IObserver observer);
        void Unsubscribe(IObserver observer);
        void Notify();
    }
}
