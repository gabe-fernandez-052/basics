namespace DesignPatterns.Creational.Builder.Products
{
    public class Wall
    {
        public string Description { get; private set; }

        public Wall() => Description = "A plain wall";
    }
}