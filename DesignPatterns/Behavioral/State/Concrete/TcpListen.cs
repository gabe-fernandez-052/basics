using DesignPatterns.Behavioral.State.State;

namespace DesignPatterns.Behavioral.State.Concrete
{
    public class TcpListen : ITcpState
    {
        public void Open(TcpConnection connection) =>
            Console.WriteLine("TcpListen: already listening.");

        public void Close(TcpConnection connection)
        {
            Console.WriteLine("TcpListen: closing, transitioning to Closed.");
            connection.ChangeState(new TcpClosed());
        }

        public void Acknowledge(TcpConnection connection)
        {
            Console.WriteLine("TcpListen: received SYN-ACK, transitioning to Established.");
            connection.ChangeState(new TcpEstablished());
        }
    }
}
