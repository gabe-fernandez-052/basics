namespace DesignPatterns.Creational.FactoryMethod.Products
{
    public class ResultsPage : Page
    {
        public ResultsPage() : base("Results Page")
        {
        }

        public override void CustomizeContent() => Content = "This section displays the results.";
    }
}