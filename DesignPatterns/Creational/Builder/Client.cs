using DesignPatterns.Creational.Builder.Builders;
using DesignPatterns.Creational.Builder.Directors;
using DesignPatterns.Creational.Builder.Products;

namespace DesignPatterns.Creational.Builder
{
    /// <summary>
    /// When to use?
    /// The Algorithm for creating a complex object should be independent of the parts that make up the object and how they're assembled
    /// The construction process must allow different representations for the object that's constructed
    /// </summary>
    public class Client
    {
        public void Run()
        {
            var mazeBuilder = new StandardMazeBuilder();
            var game = new MazeGame();

            Maze maze = game.CreateMaze(mazeBuilder);
            maze.ShowRooms();

            Console.WriteLine("Maze created successfully!");
        }
    }
}