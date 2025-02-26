namespace DesignPatterns.Structural.Facade.Subsystem
{
    public class Projector
    {
        public void On() => Console.WriteLine("Projector is On.");

        public void SetInput() => Console.WriteLine("Projector input set to DVD Player.");
    }
}