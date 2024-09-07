using DesignPatterns.Creational.Builder.Builders;
using DesignPatterns.Creational.Builder.Products;

namespace DesignPatterns.Creational.Builder.Director
{
    public class MazeGame
    {
        public Maze CreateMaze(MazeBuilder builder)
        {
            builder.BuildRoom(1);
            builder.BuildRoom(2);
            builder.BuildDoor(1, 2);

            return builder.GetMaze();
        }
    }
}