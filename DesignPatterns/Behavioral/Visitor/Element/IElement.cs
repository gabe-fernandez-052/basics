using DesignPatterns.Behavioral.Visitor.Visitor;

namespace DesignPatterns.Behavioral.Visitor.Element
{
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }
}
