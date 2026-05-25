namespace DesignPatterns.Behavioral.ChainOfResponsibility.Handler
{
    public abstract class ExpenseHandler
    {
        protected ExpenseHandler? Next;

        public void SetNext(ExpenseHandler handler) => Next = handler;

        public abstract void Handle(decimal amount);
    }
}
