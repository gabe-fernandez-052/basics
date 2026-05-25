namespace DesignPatterns.Behavioral.Iterator.Iterator
{
    public interface IIterator<T>
    {
        bool HasNext();
        T Next();
    }
}
