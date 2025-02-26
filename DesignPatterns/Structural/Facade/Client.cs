using DesignPatterns.Structural.Facade.Facade;
using DesignPatterns.Structural.Facade.Subsystem;

namespace DesignPatterns.Structural.Facade
{
    /// <summary>
    /// What is it?
    /// The Facade Pattern is a structural design pattern that provides a simplified interface to a complex subsystem.
    /// It hides the complexities of the system and provides a unified interface for easier access.
    /// When to use?
    /// You want to provide a simple interface to a complex subsystem. Subsystems often get more complex as they evolve. Most patterns, when applied, result in more and msaller classes.
    /// This makes the subsystem more reusable and easier to customize it, but it also becomes harder to use for clients that don't need to customize it. A facade can provide
    /// a simple default view of the subsystem that is good enough for most clients. Only clients needing more customizability will need to look beyond the facade.
    /// </summary>
    public class Client
    {
        public void Run()
        {
            // Create subsystem instances
            var amplifier = new Amplifier();
            var dvdPlayer = new DVDPlayer();
            var projector = new Projector();
            var lights = new Lights();

            // Create Facade
            var homeTheater = new HomeTheaterFacade(amplifier, dvdPlayer, projector, lights);

            // Use simplified interface
            homeTheater.WatchMovie("Inception");
        }
    }
}