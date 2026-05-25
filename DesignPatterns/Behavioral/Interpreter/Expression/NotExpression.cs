using DesignPatterns.Behavioral.Interpreter.Context;

namespace DesignPatterns.Behavioral.Interpreter.Expression
{
    public class NotExpression(IExpression expression) : IExpression
    {
        private readonly IExpression _expression = expression;

        public bool Evaluate(BooleanContext context) => !_expression.Evaluate(context);
    }
}
