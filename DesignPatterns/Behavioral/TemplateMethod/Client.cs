using DesignPatterns.Behavioral.TemplateMethod.Concrete;

namespace DesignPatterns.Behavioral.TemplateMethod
{
    /// <summary>
    /// What is it?
    /// Define the skeleton of an algorithm in an operation, deferring some steps to subclasses.
    /// Template Method lets subclasses redefine certain steps of an algorithm without changing the algorithm's structure.
    /// When to use?
    /// You want to implement the invariant parts of an algorithm once and leave it up to subclasses to implement the behavior that can vary.
    /// When common behavior among subclasses should be factored and localized in a common class to avoid code duplication.
    /// You want to control at which points subclasses are allowed to extend a base class algorithm (hook operations).
    /// </summary>
    public class Client
    {
        public void Run()
        {
            var app = new MyApplication();

            Console.WriteLine("Opening a supported document:");
            app.OpenDocument("report.txt");

            Console.WriteLine();
            Console.WriteLine("Opening an unsupported document:");
            app.OpenDocument("image.png");
        }
    }
}
