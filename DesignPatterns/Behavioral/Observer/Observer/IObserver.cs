namespace DesignPatterns.Behavioral.Observer.Observer
{
    public interface IObserver
    {
        void Update(string stockName, decimal price);
    }
}
