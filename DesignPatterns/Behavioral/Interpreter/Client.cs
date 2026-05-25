using DesignPatterns.Behavioral.Interpreter.Context;
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
            // Expression: (true AND x) OR (y AND (NOT x))
            var x = new VariableExpression("x");
            var y = new VariableExpression("y");

            var expression = new OrExpression(
                new AndExpression(new Constant(true), x),
                new AndExpression(y, new NotExpression(x))
            );

            var context = new BooleanContext();

            context.Assign("x", false);
            context.Assign("y", true);
            Console.WriteLine("(true AND x) OR (y AND NOT x)");
            Console.WriteLine($"  x=false, y=true  => {expression.Evaluate(context)}");

            context.Assign("x", true);
            context.Assign("y", true);
            Console.WriteLine($"  x=true,  y=true  => {expression.Evaluate(context)}");

            context.Assign("x", true);
            context.Assign("y", false);
            Console.WriteLine($"  x=true,  y=false => {expression.Evaluate(context)}");
        }
    }
}
