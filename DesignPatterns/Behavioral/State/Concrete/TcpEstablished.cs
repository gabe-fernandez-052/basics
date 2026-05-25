using DesignPatterns.Behavioral.State.State;

namespace DesignPatterns.Behavioral.State.Concrete
{
    public class TcpEstablished : ITcpState
    {
        public void Open(TcpConnection connection) =>
            Console.WriteLine("TcpEstablished: connection already open.");

        public void Close(TcpConnection connection)
        {
            Console.WriteLine("TcpEstablished: sending FIN, transitioning to Closed.");
            connection.ChangeState(new TcpClosed());
        }

        public void Acknowledge(TcpConnection connection) =>
            Console.WriteLine("TcpEstablished: data acknowledged.");
    }
}
