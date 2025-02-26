namespace DesignPatterns.Structural.Facade.Subsystem
{
    public class Amplifier
    {
        public void On() => Console.WriteLine("Amplifier is On.");
        public void SetVolume(int level) => Console.WriteLine($"Amplifier volume set to {level}.");
    }
}