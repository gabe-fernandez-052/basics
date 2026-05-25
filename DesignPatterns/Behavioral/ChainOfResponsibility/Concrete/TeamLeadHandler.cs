using DesignPatterns.Behavioral.ChainOfResponsibility.Handler;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.Concrete
{
    public class TeamLeadHandler : ExpenseHandler
    {
        public override void Handle(decimal amount)
        {
            if (amount <= 500)
                Console.WriteLine($"TeamLead approved expense of ${amount}");
            else
                Next?.Handle(amount);
        }
    }
}
