using DesignPatterns.Behavioral.Visitor.Element;

namespace DesignPatterns.Behavioral.Visitor.Visitor
{
    public interface IVisitor
    {
        void Visit(FileElement file);
        void Visit(DirectoryElement directory);
    }
}
