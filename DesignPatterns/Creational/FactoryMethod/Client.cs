using DesignPatterns.Creational.FactoryMethod.Creators;

namespace DesignPatterns.Creational.FactoryMethod
{
    /// <summary>
    /// What is it?
    /// Define an interface for creating an object, but let subclasses decide which class to instantiate. Factory method lets a class defer instantiation to subclass
    /// When to use?
    /// A class can't anticipate the class of objects it must create
    /// A class wants its subclasses to specify the objects it creates
    /// Class delegate resposibility to one of several helper subclasses, and you want to localize the knowledge of which helper subclass is the delegate
    /// The application class only knows when a new document should be created, not what kind of document to create
    /// </summary>
    public class Client
    {
        public void Run()
        {
            // Create a report document using the ReportCreator
            var reportCreator = new ReportCreator();
            Products.Document report = reportCreator.CreateDocument();

            Console.WriteLine("Report Pages:");

            foreach (var page in report.Pages)
            {
                page.Display();
                Console.WriteLine();
            }

            // Create a resume document using the ResumeCreator
            var resumeCreator = new ResumeCreator();
            Products.Document resume = resumeCreator.CreateDocument();

            Console.WriteLine("\nResume Pages:");

            foreach (var page in resume.Pages)
            {
                page.Display();
                Console.WriteLine();
            }
        }
    }
}