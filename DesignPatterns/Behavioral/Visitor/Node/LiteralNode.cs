using DesignPatterns.Behavioral.Visitor.Visitor;

namespace DesignPatterns.Behavioral.Visitor.Node
{
    public class LiteralNode(double value) : INode
    {
        public double Value { get; } = value;

        public void Accept(IVisitor visitor) => visitor.VisitLiteral(this);
    }
}
