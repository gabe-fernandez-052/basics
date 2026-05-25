namespace DesignPatterns.Behavioral.Interpreter.Expression
{
    public class OrExpression(IExpression left, IExpression right) : IExpression
    {
        private readonly IExpression _left = left;
        private readonly IExpression _right = right;

        public bool Interpret(HashSet<string> context) =>
            _left.Interpret(context) || _right.Interpret(context);
    }
}
