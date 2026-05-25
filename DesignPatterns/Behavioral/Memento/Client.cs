using DesignPatterns.Behavioral.Memento.Caretaker;
using DesignPatterns.Behavioral.Memento.Originator;

namespace DesignPatterns.Behavioral.Memento
{
    /// <summary>
    /// What is it?
    /// Without violating encapsulation, capture and externalize an object's internal state so that the object can be
    /// restored to this state later.
    /// When to use?
    /// A snapshot of an object's state must be saved so that it can be restored to that state later.
    /// A direct interface to obtaining the state would expose implementation details and break the object's encapsulation.
    /// </summary>
    public class Client
    {
        public void Run()
        {
            var graphic = new Graphic("red", 0, 0, 100);

            var move1 = new MoveCommand(graphic, 10, 20);
            move1.Execute();

            var move2 = new MoveCommand(graphic, 5, 5);
            move2.Execute();

            Console.WriteLine();
            Console.WriteLine("Undoing last move:");
            move2.Undo();

            Console.WriteLine();
            Console.WriteLine("Undoing first move:");
            move1.Undo();
        }
    }
}
