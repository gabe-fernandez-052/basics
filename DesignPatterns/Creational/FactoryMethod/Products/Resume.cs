namespace DesignPatterns.Creational.FactoryMethod.Products
{
    public class Resume : Document
    {
        public override void CreatePages()
        {
            var skills = new SkillsPage();
            skills.CustomizeContent();
            pages.Add(skills);

            var education = new EducationPage();
            education.CustomizeContent();
            pages.Add(education);

            var experience = new ExperiencePage();
            experience.CustomizeContent();
            pages.Add(experience);
        }
    }
}