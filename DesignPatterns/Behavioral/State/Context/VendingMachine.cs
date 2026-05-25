using DesignPatterns.Behavioral.State.State;

namespace DesignPatterns.Behavioral.State.Context
{
    public class VendingMachine
    {
        public IState CurrentState { get; set; }

        public VendingMachine()
        {
            CurrentState = new IdleState();
        }

        public void InsertMoney()    => CurrentState.InsertMoney(this);
        public void SelectProduct()  => CurrentState.SelectProduct(this);
        public void Dispense()       => CurrentState.Dispense(this);
    }
}
