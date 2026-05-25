namespace DesignPatterns.Behavioral.Command.Receiver
{
    public class Document(string name)
    {
        public string Name { get; } = name;

        public void Open()  => Console.WriteLine($"Document '{Name}': opened.");
        public void Paste() => Console.WriteLine($"Document '{Name}': content pasted.");
    }
}
