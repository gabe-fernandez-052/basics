namespace DesignPatterns.Creational.FactoryMethod.Products
{
    public class IntroductionPage : Page
    {
        public IntroductionPage() : base("Introduction Page")
        {
        }

        public override void CustomizeContent() => Content = "This is the introduction to the report.";
    }
}