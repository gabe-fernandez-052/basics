using DesignPatterns.Creational.Builder.Products;

namespace DesignPatterns.Creational.Builder.Builders
{
    public class StandardMazeBuilder : MazeBuilder
    {
        private readonly Maze _maze = new();

        public override void BuildRoom(int roomNumber)
        {
            var room = new Room(roomNumber);

            room.SetWall("North", new Wall());
            room.SetWall("South", new Wall());
            room.SetWall("East", new Wall());
            room.SetWall("West", new Wall());

            _maze.AddRoom(room);
        }

        public override void BuildDoor(int roomFrom, int roomTo)
        {
            Room r1 = _maze.GetRoom(roomFrom);
            Room r2 = _maze.GetRoom(roomTo);

            if (r1 != null && r2 != null)
            {
                var door = new Door(r1, r2);

                r1.Door = door;
                r2.Door = door;
            }
        }

        public override Maze GetMaze() => _maze;
    }
}