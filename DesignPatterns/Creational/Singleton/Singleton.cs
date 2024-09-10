namespace DesignPatterns.Creational.Singleton
{
    public class Singleton
    {
        /// <summary>
        /// Lazy<Singleton>: The Lazy<T> type ensures that the Singleton instance is only created when it is first accessed (lazy initialization).
        /// It also ensures thread safety without additional locking mechanisms.
        /// </summary>
        private static readonly Lazy<Singleton> _instance = new(() => new Singleton());

        public static Singleton Instance => _instance.Value;

        public void DoSomething() => Console.WriteLine("Singleton is doing something!");
    }
}
