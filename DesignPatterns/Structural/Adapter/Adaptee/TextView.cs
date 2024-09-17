namespace DesignPatterns.Structural.Adapter.Adaptee
{
    public class TextView
    {
        public void GetExtent(out int width, out int height)
        {
            // Calculate the extent (for simplicity, fixed size)
            width = 100;
            height = 50;
            Console.WriteLine("TextView: Extent calculated.");
        }

        public void DisplayText()
        {
            Console.WriteLine("TextView: Displaying text.");
        }
    }
}