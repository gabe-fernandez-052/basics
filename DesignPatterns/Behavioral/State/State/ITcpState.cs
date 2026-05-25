namespace DesignPatterns.Behavioral.State.State
{
    public interface ITcpState
    {
        void Open(TcpConnection connection);
        void Close(TcpConnection connection);
        void Acknowledge(TcpConnection connection);
    }
}
