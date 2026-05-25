using DesignPatterns.Behavioral.State.Context;

namespace DesignPatterns.Behavioral.State.State
{
    public class IdleState : IState
    {
        public void InsertMoney(VendingMachine machine)
        {
            Console.WriteLine("Money inserted. Ready to select a product.");
            machine.CurrentState = new HasMoneyState();
        }

        public void SelectProduct(VendingMachine machine)
        {
            Console.WriteLine("Please insert money first.");
        }

        public void Dispense(VendingMachine machine)
        {
            Console.WriteLine("Please insert money and select a product first.");
        }
    }
}
