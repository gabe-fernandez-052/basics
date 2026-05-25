namespace DesignPatterns.Behavioral.TemplateMethod.Abstract
{
    public abstract class DocumentBase(string name)
    {
        public string Name { get; } = name;

        public abstract void Open();
        public abstract void Close();
        public abstract void Save();
    }
}
