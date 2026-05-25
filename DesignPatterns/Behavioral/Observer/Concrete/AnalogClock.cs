using DesignPatterns.Behavioral.Observer.Observer;
using DesignPatterns.Behavioral.Observer.Subject;

namespace DesignPatterns.Behavioral.Observer.Concrete
{
    public class AnalogClock(ClockTimer timer) : IObserver
    {
        private readonly ClockTimer _timer = timer;

        public void Update()
        {
            Console.WriteLine(
                $"AnalogClock: hour hand at {_timer.GetHour() % 12}h, " +
                $"minute hand at {_timer.GetMinute()}m, " +
                $"second hand at {_timer.GetSecond()}s");
        }
    }
}
