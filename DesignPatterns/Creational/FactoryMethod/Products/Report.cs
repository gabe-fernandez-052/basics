namespace DesignPatterns.Creational.FactoryMethod.Products
{
    public class Report : Document
    {
        public override void CreatePages()
        {
            var introduction = new IntroductionPage();
            introduction.CustomizeContent();
            pages.Add(introduction);

            var results = new ResultsPage();
            results.CustomizeContent();
            pages.Add(results);

            var conclusion = new ConclusionPage();
            conclusion.CustomizeContent();
            pages.Add(conclusion);
        }
    }
}