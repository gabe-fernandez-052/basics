using DesignPatterns.Behavioral.Interpreter.Expression;

namespace DesignPatterns.Behavioral.Interpreter
{
    /// <summary>
    /// What is it?
    /// Given a language, define a representation for its grammar along with an interpreter that uses the representation
    /// to interpret sentences in the language.
    /// When to use?
    /// The grammar is simple. For complex grammars, other tools such as parser generators are better choices.
    /// Efficiency is not a critical concern.
    /// You need to interpret sentences in a language and can represent sentences as abstract syntax trees.
    /// </summary>
    public class Client
    {
        public void Run()
        {
            // Rule: "admin AND (editor OR viewer)"
            IExpression admin  = new TerminalExpression("admin");
            IExpression editor = new TerminalExpression("editor");
            IExpression viewer = new TerminalExpression("viewer");

            IExpression editorOrViewer = new OrExpression(editor, viewer);
            IExpression rule = new AndExpression(admin, editorOrViewer);

            var context1 = new HashSet<string> { "admin", "editor" };
            var context2 = new HashSet<string> { "editor" };
            var context3 = new HashSet<string> { "admin" };

            Console.WriteLine("Rule: admin AND (editor OR viewer)");
            Console.WriteLine($"  [admin, editor] => {rule.Interpret(context1)}");
            Console.WriteLine($"  [editor]        => {rule.Interpret(context2)}");
            Console.WriteLine($"  [admin]         => {rule.Interpret(context3)}");
        }
    }
}
