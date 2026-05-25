using DesignPatterns.Behavioral.State.Context;

namespace DesignPatterns.Behavioral.State.State
{
    public interface IState
    {
        void InsertMoney(VendingMachine machine);
        void SelectProduct(VendingMachine machine);
        void Dispense(VendingMachine machine);
    }
}
