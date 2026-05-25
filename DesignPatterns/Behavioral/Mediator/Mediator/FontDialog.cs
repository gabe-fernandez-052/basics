using DesignPatterns.Behavioral.Mediator.Widget;

namespace DesignPatterns.Behavioral.Mediator.Mediator
{
    public class FontDialog : IDirector
    {
        private readonly ListBox _fontList;
        private readonly EntryField _fontName;

        public FontDialog()
        {
            _fontList = new ListBox(this);
            _fontName = new EntryField(this);
        }

        public void WidgetChanged(WidgetBase widget)
        {
            if (widget == _fontList)
                _fontName.SetText(_fontList.GetSelection());
        }

        public void SelectFont(string font) => _fontList.Select(font);
    }
}
