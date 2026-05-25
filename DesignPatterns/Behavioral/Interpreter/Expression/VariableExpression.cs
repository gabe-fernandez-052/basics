using DesignPatterns.Behavioral.Interpreter.Context;

namespace DesignPatterns.Behavioral.Interpreter.Expression
{
    public class VariableExpression(string name) : IExpression
    {
        private readonly string _name = name;

        public bool Evaluate(BooleanContext context) => context.Lookup(_name);
    }
}
