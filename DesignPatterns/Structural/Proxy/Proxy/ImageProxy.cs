using DesignPatterns.Structural.Proxy.RealSubject;
using DesignPatterns.Structural.Proxy.Subject;

namespace DesignPatterns.Structural.Proxy.Proxy
{
    public class ImageProxy(string filename) : IImage
    {
        private readonly string _filename = filename;
        private RealImage? _realImage;

        public void Display()
        {
            _realImage ??= new RealImage(_filename);
            _realImage.Display();
        }
    }
}
