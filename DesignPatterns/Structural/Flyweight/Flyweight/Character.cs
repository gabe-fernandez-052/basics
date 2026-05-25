namespace DesignPatterns.Structural.Flyweight.Flyweight
{
    public class Character(char symbol, string font, int size) : ICharacter
    {
        private readonly char _symbol = symbol;
        private readonly string _font = font;
        private readonly int _size = size;

        public void Display(int row, int column)
        {
            Console.WriteLine($"Character '{_symbol}' | Font: {_font} | Size: {_size} | Position: ({row}, {column})");
        }
    }
}
