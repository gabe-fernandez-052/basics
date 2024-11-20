using DesignPatterns.Structural.Adapter.Adaptee;
using DesignPatterns.Structural.Adapter.Adapter;
using DesignPatterns.Structural.Adapter.Target;

namespace DesignPatterns.Structural.Adapter
{
    /// <summary>
    /// What is it?
    /// Convert the interface of a class into another interface clients expect. Adapter lets classes work together that couldnt otherwise because of incompatible interfaces
    /// When to use?
    /// You want to use an existing class, and its interface does not match th one you need.
    /// You want to create a reusable class that cooperates with unrelated or unforeseen classes, that is, classes that don't necessarily have compatible interfaces.
    /// You need to use several existing subclasses, but it's impractical to adapt their interface by subclassing every one. An object adapter can adapt the interface of its parent class.
    /// </summary>
    public class Client
    {
        public void Run()
        {
            // Create an instance of TextView (legacy component)
            var textView = new TextView();

            // Create the adapter to adapt TextView to IShape
            IShape textShape = new TextShapeAdapter(textView);

            // Create the DrawingEditor
            var editor = new DrawingEditor();

            // Add the adapted TextView (via TextShapeAdapter) to the editor
            editor.AddShape(textShape);

            // Render all shapes (including the adapted TextView)
            editor.Render();
        }
    }
}