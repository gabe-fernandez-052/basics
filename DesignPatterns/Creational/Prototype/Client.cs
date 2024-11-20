namespace DesignPatterns.Creational.Prototype
{
    /// <summary>
    /// What is it?
    /// Specify the kinds of objects to create using a prototypical instance, and create new objects by copying the prototype
    /// When to use?
    /// When a system should be independent of how its products created, composed, and represented
    /// When the classes to instantiate are specified at run-time, for example, by dynamic loading
    /// To avoid building a class hierarchy of factories that paralells the class hierarchy of products
    /// When instances of a class can have one of only a few different combinations of state. It may be more conventient to install a corresponding number of
    /// prototypes and clone them rather than instantiating the class manually, each time with the appropriate state
    /// </summary>
    public class Client
    {
        public void Run()
        {
            // Create instances of Circle and Rectangle
            var circle = new Circle(10);
            var rectangle = new Rectangle(20, 30);

            // Clone the shapes
            var clonedCircle = (Circle)circle.Clone();
            var clonedRectangle = (Rectangle)rectangle.Clone();

            // Display the original and cloned objects
            Console.WriteLine("Original Circle: " + circle);
            Console.WriteLine("Cloned Circle: " + clonedCircle);

            Console.WriteLine("Original Rectangle: " + rectangle);
            Console.WriteLine("Cloned Rectangle: " + clonedRectangle);

            // Change the original objects and see if clones are unaffected
            circle.Radius = 15;
            rectangle.Width = 40;

            Console.WriteLine("\nAfter modifying the original objects:");
            Console.WriteLine("Original Circle: " + circle);
            Console.WriteLine("Cloned Circle: " + clonedCircle); // Cloned version remains unaffected

            Console.WriteLine("Original Rectangle: " + rectangle);
            Console.WriteLine("Cloned Rectangle: " + clonedRectangle); // Cloned version remains unaffected
        }
    }
}