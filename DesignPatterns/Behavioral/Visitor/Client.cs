using DesignPatterns.Behavioral.Visitor.Element;
using DesignPatterns.Behavioral.Visitor.Visitor;

namespace DesignPatterns.Behavioral.Visitor
{
    /// <summary>
    /// What is it?
    /// Represent an operation to be performed on the elements of an object structure.
    /// Visitor lets you define a new operation without changing the classes of the elements on which it operates.
    /// When to use?
    /// An object structure contains many classes of objects with differing interfaces, and you want to perform
    /// operations on these objects that depend on their concrete classes.
    /// Many distinct and unrelated operations need to be performed on objects in an object structure, and you want
    /// to avoid polluting their classes with these operations.
    /// The classes defining the object structure rarely change, but you often want to define new operations over the structure.
    /// </summary>
    public class Client
    {
        public void Run()
        {
            var elements = new List<IElement>
            {
                new FileElement("report.pdf", 2048),
                new DirectoryElement("images", 3),
                new FileElement("readme.txt", 512),
                new DirectoryElement("src", 15),
            };

            var display = new DisplayVisitor();
            var size    = new SizeVisitor();

            Console.WriteLine("Display visitor:");
            foreach (var element in elements)
                element.Accept(display);

            Console.WriteLine("\nSize visitor:");
            foreach (var element in elements)
                element.Accept(size);

            Console.WriteLine($"\nTotal tracked size: {size.TotalSize} KB");
        }
    }
}
