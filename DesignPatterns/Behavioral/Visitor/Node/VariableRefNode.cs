using DesignPatterns.Behavioral.Visitor.Visitor;

namespace DesignPatterns.Behavioral.Visitor.Node
{
    public class VariableRefNode(string name) : INode
    {
        public string Name { get; } = name;

        public void Accept(IVisitor visitor) => visitor.VisitVariableRef(this);
    }
}
