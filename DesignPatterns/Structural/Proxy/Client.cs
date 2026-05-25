using DesignPatterns.Structural.Proxy.Proxy;
using DesignPatterns.Structural.Proxy.Subject;

namespace DesignPatterns.Structural.Proxy
{
    /// <summary>
    /// What is it?
    /// Provide a surrogate or placeholder for another object to control access to it.
    /// When to use?
    /// You need a more versatile or sophisticated reference to an object than a simple pointer.
    /// A virtual proxy creates expensive objects on demand (lazy initialization).
    /// A protection proxy controls access to the original object based on permissions.
    /// A remote proxy provides a local representative for an object in a different address space.
    /// A smart reference proxy performs additional actions when an object is accessed.
    /// </summary>
    public class Client
    {
        public void Run()
        {
            IImage image1 = new ImageProxy("photo1.jpg");
            IImage image2 = new ImageProxy("photo2.jpg");

            Console.WriteLine("Proxies created - images not yet loaded\n");

            image1.Display();
            Console.WriteLine();

            image2.Display();
            Console.WriteLine();

            Console.WriteLine("Calling Display again - image already loaded:");
            image1.Display();
        }
    }
}
