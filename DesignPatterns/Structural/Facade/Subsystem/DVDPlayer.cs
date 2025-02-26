namespace DesignPatterns.Structural.Facade.Subsystem
{
    public class DVDPlayer
    {
        public void On() => Console.WriteLine("DVD Player is On.");

        public void Play(string movie) => Console.WriteLine($"Playing movie: {movie}");
    }
}