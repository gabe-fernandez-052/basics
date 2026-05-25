namespace DesignPatterns.Behavioral.Command.Receiver
{
    public class TextEditor
    {
        private string _content = string.Empty;

        public void InsertText(string text)
        {
            _content += text;
            Console.WriteLine($"Inserted '{text}'. Content: '{_content}'");
        }

        public void DeleteText(string text)
        {
            if (_content.EndsWith(text))
            {
                _content = _content[..^text.Length];
                Console.WriteLine($"Deleted '{text}'. Content: '{_content}'");
            }
        }
    }
}
