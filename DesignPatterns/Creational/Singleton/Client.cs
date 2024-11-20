namespace DesignPatterns.Creational.Singleton
{
    /// <summary>
    /// What is it?
    /// Ensure a class only has one instance, and provide a global point of access to it
    /// When to use?
    /// There must be exactly oine instance of a class, and it must be accesible to clients from a well-known access point
    /// When the sole instance should be extensible by subclassing, and clients should be able to use an extended instance without modifying their code
    /// </summary>
    public class Client
    {
        public void Run()
        {
            // Access the Singleton instance.
            var singleton1 = Singleton.Instance;
            singleton1.DoSomething();

            // Trying to access the Singleton again returns the same instance.
            var singleton2 = Singleton.Instance;
            singleton2.DoSomething();

            // Check if both instances are the same. True.
            Console.WriteLine(ReferenceEquals(singleton1, singleton2));
        }
    }
}