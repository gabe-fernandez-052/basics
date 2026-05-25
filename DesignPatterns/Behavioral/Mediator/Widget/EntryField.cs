using DesignPatterns.Behavioral.Mediator.Mediator;

namespace DesignPatterns.Behavioral.Mediator.Widget
{
    public class EntryField(IDirector director) : WidgetBase(director)
    {
        private string _text = string.Empty;

        public void SetText(string text)
        {
            _text = text;
            Console.WriteLine($"EntryField updated to: '{_text}'");
        }
    }
}
