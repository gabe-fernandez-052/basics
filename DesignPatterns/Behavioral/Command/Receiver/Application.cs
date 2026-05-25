namespace DesignPatterns.Behavioral.Command.Receiver
{
    public class Application
    {
        private readonly List<Document> _documents = new();

        public void NewDocument(string name)
        {
            var doc = new Document(name);
            _documents.Add(doc);
            Console.WriteLine($"Application: document '{name}' created.");
        }

        public Document? LastDocument => _documents.LastOrDefault();
    }
}
