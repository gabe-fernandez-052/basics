using DesignPatterns.Structural.Flyweight.Flyweight;

namespace DesignPatterns.Structural.Flyweight
{
    public class CharacterFactory
    {
        private readonly Dictionary<string, ICharacter> _characters = new();

        public ICharacter GetCharacter(char symbol, string font, int size)
        {
            string key = $"{symbol}-{font}-{size}";

            if (!_characters.TryGetValue(key, out var character))
            {
                character = new Character(symbol, font, size);
                _characters[key] = character;
                Console.WriteLine($"Creating new flyweight for '{symbol}'");
            }

            return character;
        }

        public int TotalFlyweights => _characters.Count;
    }
}
