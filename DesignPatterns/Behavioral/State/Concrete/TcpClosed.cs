using DesignPatterns.Behavioral.State.State;

namespace DesignPatterns.Behavioral.State.Concrete
{
    public class TcpClosed : ITcpState
    {
        public void Open(TcpConnection connection)
        {
            Console.WriteLine("TcpClosed: sending SYN, transitioning to Listen.");
            connection.ChangeState(new TcpListen());
        }

        public void Close(TcpConnection connection) =>
            Console.WriteLine("TcpClosed: already closed.");

        public void Acknowledge(TcpConnection connection) =>
            Console.WriteLine("TcpClosed: ignoring ACK.");
    }
}
