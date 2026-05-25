namespace DesignPatterns.Behavioral.State
{
    /// <summary>
    /// What is it?
    /// Allow an object to alter its behavior when its internal state changes. The object will appear to change its class.
    /// When to use?
    /// An object's behavior depends on its state, and it must change its behavior at run time depending on that state.
    /// Operations have large, multipart conditional statements that depend on the object's state.
    /// </summary>
    public class Client
    {
        public void Run()
        {
            var connection = new TcpConnection();

            Console.WriteLine("Opening connection:");
            connection.Open();

            Console.WriteLine();
            Console.WriteLine("Acknowledging (completing handshake):");
            connection.Acknowledge();

            Console.WriteLine();
            Console.WriteLine("Acknowledging data:");
            connection.Acknowledge();

            Console.WriteLine();
            Console.WriteLine("Closing connection:");
            connection.Close();

            Console.WriteLine();
            Console.WriteLine("Trying to close again:");
            connection.Close();
        }
    }
}
