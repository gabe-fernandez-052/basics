using DesignPatterns.Behavioral.ChainOfResponsibility.Handler;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.Concrete
{
    public class DirectorHandler : ExpenseHandler
    {
        public override void Handle(decimal amount)
        {
            if (amount <= 10000)
                Console.WriteLine($"Director approved expense of ${amount}");
            else
                Console.WriteLine($"Expense of ${amount} exceeds all approval authority. Escalate to Board.");
        }
    }
}
