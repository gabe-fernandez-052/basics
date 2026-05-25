using DesignPatterns.Behavioral.TemplateMethod.Abstract;

namespace DesignPatterns.Behavioral.TemplateMethod.Concrete
{
    public class CsvProcessor : DataProcessor
    {
        private string _data = string.Empty;

        protected override void ReadData(string data)
        {
            _data = data;
            Console.WriteLine($"  Reading CSV: {_data[..Math.Min(30, _data.Length)]}...");
        }

        protected override void ParseData()
        {
            Console.WriteLine("  Parsing CSV rows and columns");
        }

        protected override void SaveData()
        {
            Console.WriteLine("  Saving CSV records to database");
        }
    }
}
