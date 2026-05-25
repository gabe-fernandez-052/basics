using DesignPatterns.Behavioral.State.Context;

namespace DesignPatterns.Behavioral.State.State
{
    public class DispensingState : IState
    {
        public void InsertMoney(VendingMachine machine)
        {
            Console.WriteLine("Please wait. Currently dispensing.");
        }

        public void SelectProduct(VendingMachine machine)
        {
            Console.WriteLine("Please wait. Currently dispensing.");
        }

        public void Dispense(VendingMachine machine)
        {
            Console.WriteLine("Product dispensed. Returning to idle.");
            machine.CurrentState = new IdleState();
        }
    }
}
