using DesignPatterns.Behavioral.Observer.Observer;
using DesignPatterns.Behavioral.Observer.Subject;

namespace DesignPatterns.Behavioral.Observer.Concrete
{
    public class DigitalClock(ClockTimer timer) : IObserver
    {
        private readonly ClockTimer _timer = timer;

        public void Update()
        {
            Console.WriteLine(
                $"DigitalClock: {_timer.GetHour():D2}:{_timer.GetMinute():D2}:{_timer.GetSecond():D2}");
        }
    }
}
