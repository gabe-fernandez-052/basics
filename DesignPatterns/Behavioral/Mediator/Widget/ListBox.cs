using DesignPatterns.Behavioral.Mediator.Mediator;

namespace DesignPatterns.Behavioral.Mediator.Widget
{
    public class ListBox(IDirector director) : WidgetBase(director)
    {
        private string _selection = string.Empty;

        public string GetSelection() => _selection;

        public void Select(string item)
        {
            _selection = item;
            Console.WriteLine($"ListBox: '{_selection}' selected.");
            Changed();
        }
    }
}
