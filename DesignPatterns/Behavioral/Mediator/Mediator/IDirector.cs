using DesignPatterns.Behavioral.Mediator.Widget;

namespace DesignPatterns.Behavioral.Mediator.Mediator
{
    public interface IDirector
    {
        void WidgetChanged(WidgetBase widget);
    }
}
