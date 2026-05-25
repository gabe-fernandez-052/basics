namespace DesignPatterns.Behavioral.Interpreter.Context
{
    public class BooleanContext
    {
        private readonly Dictionary<string, bool> _variables = new();

        public void Assign(string name, bool value) => _variables[name] = value;

        public bool Lookup(string name) =>
            _variables.TryGetValue(name, out var val) ? val : false;
    }
}
