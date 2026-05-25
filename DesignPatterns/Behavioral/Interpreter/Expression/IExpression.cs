namespace DesignPatterns.Behavioral.Interpreter.Expression
{
    public interface IExpression
    {
        bool Interpret(HashSet<string> context);
    }
}
