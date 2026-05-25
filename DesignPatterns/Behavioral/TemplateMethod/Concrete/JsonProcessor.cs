using DesignPatterns.Behavioral.TemplateMethod.Abstract;

namespace DesignPatterns.Behavioral.TemplateMethod.Concrete
{
    public class JsonProcessor : DataProcessor
    {
        private string _data = string.Empty;

        protected override void ReadData(string data)
        {
            _data = data;
            Console.WriteLine($"  Reading JSON: {_data[..Math.Min(30, _data.Length)]}...");
        }

        protected override void ParseData()
        {
            Console.WriteLine("  Deserializing JSON structure");
        }

        protected override void ValidateData()
        {
            Console.WriteLine("  Validating JSON schema");
        }

        protected override void SaveData()
        {
            Console.WriteLine("  Saving deserialized objects to database");
        }
    }
}
