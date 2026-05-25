using DesignPatterns.Behavioral.Iterator.Iterator;

namespace DesignPatterns.Behavioral.Iterator.Aggregate
{
    public class NumberCollection : IAggregate<int>
    {
        private readonly List<int> _items = new();

        public void Add(int item) => _items.Add(item);

        public IIterator<int> CreateIterator() => new NumberIterator(_items);
    }
}
