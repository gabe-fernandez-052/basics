namespace DesignPatterns.Creational.FactoryMethod.Products
{
    public class ExperiencePage : Page
    {
        public ExperiencePage() : base("Experience Page")
        {
        }

        public override void CustomizeContent() => Content = "This section describes the work experience.";
    }
}