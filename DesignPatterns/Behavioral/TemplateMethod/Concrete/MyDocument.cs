using DesignPatterns.Behavioral.TemplateMethod.Abstract;

namespace DesignPatterns.Behavioral.TemplateMethod.Concrete
{
    public class MyDocument(string name) : DocumentBase(name)
    {
        public override void Open()  => Console.WriteLine($"MyDocument '{Name}': opened.");
        public override void Close() => Console.WriteLine($"MyDocument '{Name}': closed.");
        public override void Save()  => Console.WriteLine($"MyDocument '{Name}': saved.");
    }
}
