using DesignPatterns.Behavioral.Mediator.Colleague;
using DesignPatterns.Behavioral.Mediator.Mediator;

namespace DesignPatterns.Behavioral.Mediator
{
    /// <summary>
    /// What is it?
    /// Define an object that encapsulates how a set of objects interact. Mediator promotes loose coupling by keeping
    /// objects from referring to each other explicitly, and it lets you vary their interaction independently.
    /// When to use?
    /// A set of objects communicate in well-defined but complex ways. The resulting interdependencies are unstructured and difficult to understand.
    /// Reusing an object is difficult because it refers to and communicates with many other objects.
    /// A behavior that is distributed between several classes should be customizable without a lot of subclassing.
    /// </summary>
    public class Client
    {
        public void Run()
        {
            var chatRoom = new ChatRoom();

            var alice   = new User("Alice", chatRoom);
            var bob     = new User("Bob", chatRoom);
            var charlie = new User("Charlie", chatRoom);

            chatRoom.Register(alice);
            chatRoom.Register(bob);
            chatRoom.Register(charlie);

            alice.Send("Hello everyone!");
            bob.Send("Hey Alice!");
        }
    }
}
