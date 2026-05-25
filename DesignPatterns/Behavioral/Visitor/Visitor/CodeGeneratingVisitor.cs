using DesignPatterns.Behavioral.Visitor.Node;

namespace DesignPatterns.Behavioral.Visitor.Visitor
{
    public class CodeGeneratingVisitor : IVisitor
    {
        public void VisitAssignment(AssignmentNode node)
        {
            node.Value.Accept(this);
            Console.WriteLine($"CodeGen: STORE {node.Variable}");
        }

        public void VisitVariableRef(VariableRefNode node) =>
            Console.WriteLine($"CodeGen: LOAD {node.Name}");

        public void VisitLiteral(LiteralNode node) =>
            Console.WriteLine($"CodeGen: PUSH {node.Value}");
    }
}
