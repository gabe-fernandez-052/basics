using DesignPatterns.Behavioral.State.Context;

namespace DesignPatterns.Behavioral.State
{
    /// <summary>
    /// What is it?
    /// Allow an object to alter its behavior when its internal state changes. The object will appear to change its class.
    /// When to use?
    /// An object's behavior depends on its state, and it must change its behavior at run-time depending on that state.
    /// Operations have large, multipart conditional statements that depend on the object's state.
    /// The State pattern puts each branch of the conditional in a separate class.
    /// </summary>
    public class Client
    {
        public void Run()
        {
            var vendingMachine = new VendingMachine();

            vendingMachine.InsertMoney();
            vendingMachine.SelectProduct();
            vendingMachine.Dispense();

            Console.WriteLine();

            // Try invalid transitions
            vendingMachine.SelectProduct();
            vendingMachine.InsertMoney();
            vendingMachine.InsertMoney();
            vendingMachine.SelectProduct();
            vendingMachine.Dispense();
        }
    }
}
