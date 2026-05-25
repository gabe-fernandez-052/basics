using DesignPatterns.Behavioral.TemplateMethod.Concrete;

namespace DesignPatterns.Behavioral.TemplateMethod
{
    /// <summary>
    /// What is it?
    /// Define the skeleton of an algorithm in an operation, deferring some steps to subclasses.
    /// Template Method lets subclasses redefine certain steps of an algorithm without changing the algorithm's structure.
    /// When to use?
    /// You want to implement the invariant parts of an algorithm once and leave it up to subclasses to implement the behavior that can vary.
    /// Common behavior among subclasses should be factored and localized in a common class to avoid code duplication.
    /// You want to control which steps subclasses can extend.
    /// </summary>
    public class Client
    {
        public void Run()
        {
            Console.WriteLine("Processing CSV:");
            var csv = new CsvProcessor();
            csv.Process("name,age\nAlice,30\nBob,25");

            Console.WriteLine();

            Console.WriteLine("Processing JSON:");
            var json = new JsonProcessor();
            json.Process("{\"users\":[{\"name\":\"Alice\"},{\"name\":\"Bob\"}]}");
        }
    }
}
