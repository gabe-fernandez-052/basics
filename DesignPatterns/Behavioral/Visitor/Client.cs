using DesignPatterns.Behavioral.Visitor.Node;
using DesignPatterns.Behavioral.Visitor.Visitor;

namespace DesignPatterns.Behavioral.Visitor
{
    /// <summary>
    /// What is it?
    /// Represent an operation to be performed on the elements of an object structure. Visitor lets you define a new
    /// operation without changing the classes of the elements on which it operates.
    /// When to use?
    /// An object structure contains many classes of objects with differing interfaces, and you want to perform operations
    /// on these objects that depend on their concrete classes.
    /// Many distinct and unrelated operations need to be performed on objects in an object structure, and you want to
    /// avoid polluting their classes with these operations.
    /// The classes defining the object structure rarely change, but you often want to define new operations over the structure.
    /// </summary>
    public class Client
    {
        public void Run()
        {
            // AST for: x = 3.14
            INode ast = new AssignmentNode("x", new LiteralNode(3.14));

            // AST for: y = x
            INode ast2 = new AssignmentNode("y", new VariableRefNode("x"));

            Console.WriteLine("--- Type Checking Pass ---");
            var typeChecker = new TypeCheckingVisitor();
            ast.Accept(typeChecker);
            ast2.Accept(typeChecker);

            Console.WriteLine();
            Console.WriteLine("--- Code Generation Pass ---");
            var codeGen = new CodeGeneratingVisitor();
            ast.Accept(codeGen);
            ast2.Accept(codeGen);
        }
    }
}
