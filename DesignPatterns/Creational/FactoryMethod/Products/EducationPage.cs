namespace DesignPatterns.Creational.FactoryMethod.Products
{
    public class EducationPage : Page
    {
        public EducationPage() : base("Education Page")
        {
        }

        public override void CustomizeContent() => Content = "This section lists the education background.";
    }
}