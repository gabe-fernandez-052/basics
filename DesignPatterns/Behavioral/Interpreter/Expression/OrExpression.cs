using DesignPatterns.Behavioral.Interpreter.Context;

namespace DesignPatterns.Behavioral.Interpreter.Expression
{
    public class OrExpression(IExpression left, IExpression right) : IExpression
    {
        private readonly IExpression _left = left;
        private readonly IExpression _right = right;

        public bool Evaluate(BooleanContext context) =>
            _left.Evaluate(context) || _right.Evaluate(context);
    }
}
