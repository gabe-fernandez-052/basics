using DesignPatterns.Structural.Composite.Leaf;

namespace DesignPatterns.Structural.Composite
{
    /// <summary>
    /// What is it?
    /// Compose objects into tree structures to represent part-whole hierarchies. Composite lets clients treat individual objects and compositions of objects uniformly
    /// When to use?
    /// You want to represent part-whole hierarchies of objects
    /// You want clients to be able to ignore the difference between compositions of objects and individual objects. Clients will treat
    /// all objects in the composite structure uniformly.
    /// </summary>
    public class Client
    {
        public void Run()
        {
            var line1 = new Line();
            var line2 = new Line();
            var circle = new Circle();

            var picture = new Picture();
            picture.Add(line1);
            picture.Add(circle);

            var bigPicture = new Picture();
            bigPicture.Add(picture);
            bigPicture.Add(line2);

            bigPicture.Draw();
        }
    }
}