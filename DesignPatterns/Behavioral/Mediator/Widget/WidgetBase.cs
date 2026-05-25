using DesignPatterns.Behavioral.Mediator.Mediator;

namespace DesignPatterns.Behavioral.Mediator.Widget
{
    public abstract class WidgetBase(IDirector director)
    {
        private readonly IDirector _director = director;

        public virtual void Changed() => _director.WidgetChanged(this);
    }
}
