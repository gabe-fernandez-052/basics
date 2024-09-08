namespace DesignPatterns.Creational.FactoryMethod.Products
{
    public abstract class Page(string title)
    {
        public string Title { get; set; } = title;
        public string Content { get; set; } = "Default content";

        public virtual void Display()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Content: {Content}");
        }

        public abstract void CustomizeContent();
    }
}