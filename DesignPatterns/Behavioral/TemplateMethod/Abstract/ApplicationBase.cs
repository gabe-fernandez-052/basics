namespace DesignPatterns.Behavioral.TemplateMethod.Abstract
{
    public abstract class ApplicationBase
    {
        // Template method
        public void OpenDocument(string name)
        {
            if (!CanOpenDocument(name))
            {
                Console.WriteLine($"Application: cannot open '{name}'.");
                return;
            }

            var doc = DoCreateDocument(name);
            AddDocument(doc);
            AboutToOpenDocument(doc);
            doc.Open();
        }

        protected abstract bool CanOpenDocument(string name);
        protected abstract DocumentBase DoCreateDocument(string name);

        protected virtual void AboutToOpenDocument(DocumentBase doc) { }

        private void AddDocument(DocumentBase doc) =>
            Console.WriteLine($"Application: adding '{doc.Name}' to document list.");
    }
}
