using DesignPatterns.Behavioral.Strategy.Strategy;

namespace DesignPatterns.Behavioral.Strategy.Concrete
{
    public class PayPalPayment : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount:C} using PayPal.");
        }
    }
}
