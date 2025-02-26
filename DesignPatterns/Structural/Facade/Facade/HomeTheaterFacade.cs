using DesignPatterns.Structural.Facade.Subsystem;

namespace DesignPatterns.Structural.Facade.Facade
{
    public class HomeTheaterFacade
    {
        private readonly Amplifier _amplifier;
        private readonly DVDPlayer _dvdPlayer;
        private readonly Projector _projector;
        private readonly Lights _lights;

        public HomeTheaterFacade(Amplifier amplifier, DVDPlayer dvdPlayer, Projector projector, Lights lights)
        {
            _amplifier = amplifier;
            _dvdPlayer = dvdPlayer;
            _projector = projector;
            _lights = lights;
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("\nStarting Movie Night...");
            _lights.Dim(30);
            _amplifier.On();
            _amplifier.SetVolume(5);
            _projector.On();
            _projector.SetInput();
            _dvdPlayer.On();
            _dvdPlayer.Play(movie);
            Console.WriteLine("Movie started!\n");
        }
    }
}