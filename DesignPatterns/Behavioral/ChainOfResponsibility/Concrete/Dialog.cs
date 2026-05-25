using DesignPatterns.Behavioral.ChainOfResponsibility.Handler;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.Concrete
{
    public class Dialog : HelpHandler
    {
        private readonly string _name;

        public Dialog(HelpHandler? successor, string name, string topic = "")
            : base(successor, topic)
        {
            _name = name;
        }

        public override void HandleHelp()
        {
            if (HasHelp)
                Console.WriteLine($"Dialog '{_name}': showing help for '{Topic}'");
            else
                base.HandleHelp();
        }
    }
}
