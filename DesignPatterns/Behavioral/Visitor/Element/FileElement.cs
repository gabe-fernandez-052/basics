using DesignPatterns.Behavioral.Visitor.Visitor;

namespace DesignPatterns.Behavioral.Visitor.Element
{
    public class FileElement(string name, int sizeKb) : IElement
    {
        public string Name   { get; } = name;
        public int SizeKb    { get; } = sizeKb;

        public void Accept(IVisitor visitor) => visitor.Visit(this);
    }
}
