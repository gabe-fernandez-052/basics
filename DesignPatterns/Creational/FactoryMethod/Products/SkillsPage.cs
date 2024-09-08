namespace DesignPatterns.Creational.FactoryMethod.Products
{
    public class SkillsPage : Page
    {
        public SkillsPage() : base("Skills Page")
        {
        }

        public override void CustomizeContent() => Content = "This section lists the skills of the individual.";
    }
}