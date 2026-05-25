using DesignPatterns.Behavioral.Iterator.Aggregate;

namespace DesignPatterns.Behavioral.Iterator
{
    /// <summary>
    /// What is it?
    /// Provide a way to access the elements of an aggregate object sequentially without exposing its underlying representation.
    /// When to use?
    /// You need a standard way to traverse different types of collections.
    /// You want to support multiple simultaneous traversals of a collection.
    /// You want to provide a uniform interface for traversing different aggregate structures (polymorphic iteration).
    /// </summary>
    public class Client
    {
        public void Run()
        {
            var collection = new NumberCollection();
            collection.Add(10);
            collection.Add(20);
            collection.Add(30);
            collection.Add(40);

            var iterator = collection.CreateIterator();

            Console.WriteLine("Iterating over collection:");
            while (iterator.HasNext())
                Console.WriteLine($"  {iterator.Next()}");
        }
    }
}
