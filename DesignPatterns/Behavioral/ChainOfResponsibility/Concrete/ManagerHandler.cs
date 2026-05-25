using DesignPatterns.Behavioral.ChainOfResponsibility.Handler;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.Concrete
{
    public class ManagerHandler : ExpenseHandler
    {
        public override void Handle(decimal amount)
        {
            if (amount <= 5000)
                Console.WriteLine($"Manager approved expense of ${amount}");
            else
                Next?.Handle(amount);
        }
    }
}
