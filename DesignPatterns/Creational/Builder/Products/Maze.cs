namespace DesignPatterns.Creational.Builder.Products
{
    public class Maze
    {
        private readonly List<Room> _rooms = [];

        public void AddRoom(Room room)
        {
            _rooms.Add(room);
        }

        public Room GetRoom(int roomNumber) => _rooms.Find(room => room.RoomNumber == roomNumber);

        public void ShowRooms()
        {
            Console.WriteLine("Maze contains the following rooms:");

            foreach (var room in _rooms)
            {
                Console.WriteLine($"Room {room.RoomNumber}");
            }
        }
    }
}