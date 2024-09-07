using DesignPatterns.Creational.Builder.Products;

namespace DesignPatterns.Creational.Builder.Builders
{
    public abstract class MazeBuilder
    {
        public abstract void BuildRoom(int roomNumber);

        public abstract void BuildDoor(int roomFrom, int roomTo);

        public abstract Maze GetMaze();
    }
}