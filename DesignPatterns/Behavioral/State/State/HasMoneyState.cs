using DesignPatterns.Behavioral.State.Context;

namespace DesignPatterns.Behavioral.State.State
{
    public class HasMoneyState : IState
    {
        public void InsertMoney(VendingMachine machine)
        {
            Console.WriteLine("Money already inserted.");
        }

        public void SelectProduct(VendingMachine machine)
        {
            Console.WriteLine("Product selected. Ready to dispense.");
            machine.CurrentState = new DispensingState();
        }

        public void Dispense(VendingMachine machine)
        {
            Console.WriteLine("Please select a product first.");
        }
    }
}
