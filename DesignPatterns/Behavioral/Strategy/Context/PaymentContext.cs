using DesignPatterns.Behavioral.Strategy.Strategy;

namespace DesignPatterns.Behavioral.Strategy.Context
{
    public class PaymentContext
    {
        private IPaymentStrategy? _paymentStrategy;

        public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        public void Pay(decimal amount)
        {
            if (_paymentStrategy == null)
            {
                throw new InvalidOperationException("Payment strategy is not set.");
            }

            _paymentStrategy.Pay(amount);
        }
    }
}
