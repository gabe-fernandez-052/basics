namespace DesignPatterns.Creational.Builder.Products
{
    public class Room(int roomNumber)
    {
        public int RoomNumber { get; private set; } = roomNumber;
        public Dictionary<string, Wall> Walls { get; private set; } = [];
        public Door Door { get; set; }

        public void SetWall(string direction, Wall wall)
        {
            Walls[direction] = wall;
        }
    }
}