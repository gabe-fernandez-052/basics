using DesignPatterns.Behavioral.Visitor.Visitor;

namespace DesignPatterns.Behavioral.Visitor.Node
{
    public interface INode
    {
        void Accept(IVisitor visitor);
    }
}
