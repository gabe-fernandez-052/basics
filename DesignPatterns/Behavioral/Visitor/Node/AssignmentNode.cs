using DesignPatterns.Behavioral.Visitor.Visitor;

namespace DesignPatterns.Behavioral.Visitor.Node
{
    public class AssignmentNode(string variable, INode value) : INode
    {
        public string Variable { get; } = variable;
        public INode Value     { get; } = value;

        public void Accept(IVisitor visitor) => visitor.VisitAssignment(this);
    }
}
