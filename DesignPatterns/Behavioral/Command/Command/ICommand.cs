namespace DesignPatterns.Behavioral.Command.Command
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
