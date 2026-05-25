using DesignPatterns.Structural.Flyweight.Flyweight;

namespace DesignPatterns.Structural.Flyweight
{
    /// <summary>
    /// What is it?
    /// Use sharing to support large numbers of fine-grained objects efficiently.
    /// A flyweight is a shared object that can be used in multiple contexts simultaneously.
    /// It acts as an independent object in each context - it is indistinguishable from an instance that is not shared.
    /// When to use?
    /// An application uses a large number of objects.
    /// Storage costs are high because of the sheer quantity of objects.
    /// Most object state can be made extrinsic.
    /// Many groups of objects may be replaced by relatively few shared objects once extrinsic state is removed.
    /// The application doesn't depend on object identity.
    /// </summary>
    public class Client
    {
        public void Run()
        {
            var factory = new CharacterFactory();

            var document = new[]
            {
                ('H', "Arial", 12, 0, 0),
                ('e', "Arial", 12, 0, 1),
                ('l', "Arial", 12, 0, 2),
                ('l', "Arial", 12, 0, 3),
                ('o', "Arial", 12, 0, 4),
                ('H', "Arial", 12, 1, 0),
                ('e', "Arial", 12, 1, 1),
            };

            foreach (var (symbol, font, size, row, col) in document)
            {
                var character = factory.GetCharacter(symbol, font, size);
                character.Display(row, col);
            }

            Console.WriteLine($"\nTotal unique flyweights created: {factory.TotalFlyweights}");
        }
    }
}
