namespace DesignPatterns.Behavioral.Interpreter.Expression
{
    public class TerminalExpression(string value) : IExpression
    {
        private readonly string _value = value;

        public bool Interpret(HashSet<string> context) => context.Contains(_value);
    }
}
