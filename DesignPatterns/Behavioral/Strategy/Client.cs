using DesignPatterns.Behavioral.Strategy.Concrete;
using DesignPatterns.Behavioral.Strategy.Context;

namespace DesignPatterns.Behavioral.Strategy
{
    /// <summary>
    /// What is it?
    /// Define a familiy of algorithms, encapsulate each one, and make them interchangeable. Strategy lets the algorithm vary independently from clients that use it. 
    /// WHen to use?
    /// Many related classes differ only in their behavior. Strategies provide a way to configure a class with one of many behaviors. 
    /// You need different variants of an algorithm.
    /// An algorithm uses data that cleints shouldn't know about. Use the strategy pattern to avoid exposing complex, algorithm specific data structures
    /// A class defines many behaviors, and these appear as multiple conditional statements in its operations. Instead of many condtionals, move related conditional branches 
    /// into their own own strategy class. 
    /// </summary>
    public class Client
    {
        public void Run()
        {
            var paymentContext = new PaymentContext();

            paymentContext.SetPaymentStrategy(new CreditCardPayment());
            paymentContext.Pay(100);

            paymentContext.SetPaymentStrategy(new PayPalPayment());
            paymentContext.Pay(250);

            paymentContext.SetPaymentStrategy(new CryptoPayment());
            paymentContext.Pay(500);
        }
    }
}
