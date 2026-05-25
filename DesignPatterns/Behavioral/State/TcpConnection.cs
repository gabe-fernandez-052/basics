using DesignPatterns.Behavioral.State.Concrete;
using DesignPatterns.Behavioral.State.State;

namespace DesignPatterns.Behavioral.State
{
    public class TcpConnection
    {
        private ITcpState _state;

        public TcpConnection() => _state = new TcpClosed();

        public void ChangeState(ITcpState state) => _state = state;

        public void Open()        => _state.Open(this);
        public void Close()       => _state.Close(this);
        public void Acknowledge() => _state.Acknowledge(this);
    }
}
