using DesignPatterns.Behavioral.Interpreter.Context;

namespace DesignPatterns.Behavioral.Interpreter.Expression
{
    public interface IExpression
    {
        bool Evaluate(BooleanContext context);
    }
}
