using DesignPatterns.Behavioral.Observer.Observer;
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
            var stockMarket = new StockMarket("AAPL");

            var investor1 = new StockInvestor("Alice");
            var investor2 = new StockInvestor("Bob");

            stockMarket.Subscribe(investor1);
            stockMarket.Subscribe(investor2);

            stockMarket.SetPrice(150.00m);
            stockMarket.SetPrice(155.50m);

            Console.WriteLine("\nBob unsubscribes:");
            stockMarket.Unsubscribe(investor2);

            stockMarket.SetPrice(148.00m);
        }
    }
}
