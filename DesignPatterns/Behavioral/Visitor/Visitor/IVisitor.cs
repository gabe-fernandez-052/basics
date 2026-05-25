using DesignPatterns.Behavioral.Visitor.Node;

namespace DesignPatterns.Behavioral.Visitor.Visitor
{
    public interface IVisitor
    {
        void VisitAssignment(AssignmentNode node);
        void VisitVariableRef(VariableRefNode node);
        void VisitLiteral(LiteralNode node);
    }
}
