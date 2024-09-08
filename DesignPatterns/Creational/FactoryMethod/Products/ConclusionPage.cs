namespace DesignPatterns.Creational.FactoryMethod.Products
{
    public class ConclusionPage : Page
    {
        public ConclusionPage() : base("Conclusion Page")
        {
        }

        public override void CustomizeContent() => Content = "This is the conclusion of the report.";
    }
}