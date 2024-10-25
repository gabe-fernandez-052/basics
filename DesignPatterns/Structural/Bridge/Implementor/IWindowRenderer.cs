namespace DesignPatterns.Structural.Bridge.Implementor
{
    public interface IWindowRenderer
    {
        void DrawWindow(string title);

        void DrawButton(string text);
    }
}
