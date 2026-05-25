using DesignPatterns.Behavioral.ChainOfResponsibility.Handler;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.Concrete
{
    public class HelpApplication : HelpHandler
    {
        public HelpApplication(string topic) : base(null, topic) { }

        public override void HandleHelp()
        {
            Console.WriteLine($"Application: showing general help for '{Topic}'");
        }
    }
}
