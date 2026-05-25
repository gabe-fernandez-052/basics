namespace DesignPatterns.Behavioral.Observer.Observer
{
    public class StockInvestor(string name) : IObserver
    {
        private readonly string _name = name;

        public void Update(string stockName, decimal price)
        {
            Console.WriteLine($"  {_name} notified: {stockName} is now ${price}");
        }
    }
}
