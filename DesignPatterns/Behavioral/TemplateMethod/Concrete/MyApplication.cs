using DesignPatterns.Behavioral.TemplateMethod.Abstract;

namespace DesignPatterns.Behavioral.TemplateMethod.Concrete
{
    public class MyApplication : ApplicationBase
    {
        private static readonly string[] AllowedExtensions = [".txt", ".doc"];

        protected override bool CanOpenDocument(string name)
        {
            var ext = System.IO.Path.GetExtension(name);
            var allowed = AllowedExtensions.Contains(ext);
            if (!allowed)
                Console.WriteLine($"MyApplication: extension '{ext}' not supported.");
            return allowed;
        }

        protected override DocumentBase DoCreateDocument(string name) =>
            new MyDocument(name);

        protected override void AboutToOpenDocument(DocumentBase doc) =>
            Console.WriteLine($"MyApplication: about to open '{doc.Name}'.");
    }
}
