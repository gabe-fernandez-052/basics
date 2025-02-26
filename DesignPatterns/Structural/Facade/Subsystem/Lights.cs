namespace DesignPatterns.Structural.Facade.Subsystem
{
    public class Lights
    {
        public void Dim(int level) => Console.WriteLine($"Lights dimmed to {level}%.");
    }
}