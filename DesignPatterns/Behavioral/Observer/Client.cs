using DesignPatterns.Behavioral.Observer.Concrete;
using DesignPatterns.Behavioral.Observer.Subject;

namespace DesignPatterns.Behavioral.Observer
{
    /// <summary>
    /// What is it?
    /// Define a one-to-many dependency between objects so that when one object changes state,
    /// all its dependents are notified and updated automatically.
    /// When to use?
    /// When an abstraction has two aspects, one dependent on the other.
    /// When a change to one object requires changing others, and you don't know how many objects need to change.
    /// When an object should be able to notify other objects without making assumptions about who these objects are.
    /// </summary>
    public class Client
    {
        public void Run()
        {
            var timer   = new ClockTimer();
            var digital = new DigitalClock(timer);
            var analog  = new AnalogClock(timer);

            timer.Attach(digital);
            timer.Attach(analog);

            Console.WriteLine("Tick 1:");
            timer.Tick(9, 30, 0);

            Console.WriteLine();
            Console.WriteLine("Tick 2:");
            timer.Tick(9, 30, 1);

            Console.WriteLine();
            Console.WriteLine("Detach analog clock:");
            timer.Detach(analog);
            timer.Tick(9, 30, 2);
        }
    }
}
