namespace DesignPatterns.Behavioral.Iterator.Iterator
{
    public class NumberIterator(List<int> items) : IIterator<int>
    {
        private readonly List<int> _items = items;
        private int _index = 0;

        public bool HasNext() => _index < _items.Count;
        public int Next() => _items[_index++];
    }
}
