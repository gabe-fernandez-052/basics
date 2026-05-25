namespace DesignPatterns.Behavioral.ChainOfResponsibility.Handler
{
    public abstract class HelpHandler
    {
        private readonly HelpHandler? _successor;
        private readonly string _topic;

        protected HelpHandler(HelpHandler? successor, string topic = "")
        {
            _successor = successor;
            _topic = topic;
        }

        protected bool HasHelp => _topic.Length > 0;
        protected string Topic => _topic;

        public virtual void HandleHelp()
        {
            if (_successor != null)
                _successor.HandleHelp();
            else
                Console.WriteLine("No help available.");
        }
    }
}
