using DesignPatterns.Behavioral.Observer.Observer;

namespace DesignPatterns.Behavioral.Observer.Subject
{
    public class ClockTimer
    {
        private readonly List<IObserver> _observers = new();
        private int _hour;
        private int _minute;
        private int _second;

        public int GetHour()   => _hour;
        public int GetMinute() => _minute;
        public int GetSecond() => _second;

        public void Attach(IObserver observer) => _observers.Add(observer);
        public void Detach(IObserver observer) => _observers.Remove(observer);

        private void Notify()
        {
            foreach (var o in _observers)
                o.Update();
        }

        public void Tick(int hour, int minute, int second)
        {
            _hour   = hour;
            _minute = minute;
            _second = second;
            Notify();
        }
    }
}
