using DesignPatterns.Behavioral.Interpreter.Context;

namespace DesignPatterns.Behavioral.Interpreter.Expression
{
    public class Constant(bool value) : IExpression
    {
        private readonly bool _value = value;

        public bool Evaluate(BooleanContext context) => _value;
    }
}
