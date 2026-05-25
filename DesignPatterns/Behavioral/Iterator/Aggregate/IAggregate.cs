using DesignPatterns.Behavioral.Iterator.Iterator;

namespace DesignPatterns.Behavioral.Iterator.Aggregate
{
    public interface IAggregate<T>
    {
        IIterator<T> CreateIterator();
    }
}
