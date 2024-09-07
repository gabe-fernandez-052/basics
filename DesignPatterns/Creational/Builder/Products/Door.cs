namespace DesignPatterns.Creational.Builder.Products
{
    public class Door(Room room1, Room room2)
    {
        public Room Room1 { get; private set; } = room1;
        public Room Room2 { get; private set; } = room2;
    }
}