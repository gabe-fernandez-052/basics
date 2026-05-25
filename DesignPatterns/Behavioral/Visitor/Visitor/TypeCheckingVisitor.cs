using DesignPatterns.Behavioral.Visitor.Node;

namespace DesignPatterns.Behavioral.Visitor.Visitor
{
    public class TypeCheckingVisitor : IVisitor
    {
        public void VisitAssignment(AssignmentNode node)
        {
            Console.WriteLine($"TypeCheck: assigning to '{node.Variable}'");
            node.Value.Accept(this);
        }

        public void VisitVariableRef(VariableRefNode node) =>
            Console.WriteLine($"TypeCheck: referencing variable '{node.Name}' — checking declaration.");

        public void VisitLiteral(LiteralNode node) =>
            Console.WriteLine($"TypeCheck: literal {node.Value} — type is double.");
    }
}
