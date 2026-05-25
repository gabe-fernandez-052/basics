using DesignPatterns.Behavioral.Visitor.Visitor;

namespace DesignPatterns.Behavioral.Visitor.Element
{
    public class DirectoryElement(string name, int fileCount) : IElement
    {
        public string Name    { get; } = name;
        public int FileCount  { get; } = fileCount;

        public void Accept(IVisitor visitor) => visitor.Visit(this);
    }
}
