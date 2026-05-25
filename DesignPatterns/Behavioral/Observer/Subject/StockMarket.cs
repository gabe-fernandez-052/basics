using DesignPatterns.Behavioral.Observer.Observer;

namespace DesignPatterns.Behavioral.Observer.Subject
{
    public class StockMarket(string stockName) : ISubject
    {
        private readonly string _stockName = stockName;
        private readonly List<IObserver> _observers = new();
        private decimal _price;

        public void Subscribe(IObserver observer) => _observers.Add(observer);
        public void Unsubscribe(IObserver observer) => _observers.Remove(observer);

        public void SetPrice(decimal price)
        {
            _price = price;
            Console.WriteLine($"\n{_stockName} price changed to ${_price}");
            Notify();
        }

        public void Notify()
        {
            foreach (var observer in _observers)
                observer.Update(_stockName, _price);
        }
    }
}
