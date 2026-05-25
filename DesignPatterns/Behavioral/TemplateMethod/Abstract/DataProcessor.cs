namespace DesignPatterns.Behavioral.TemplateMethod.Abstract
{
    public abstract class DataProcessor
    {
        public void Process(string data)
        {
            ReadData(data);
            ParseData();
            ValidateData();
            SaveData();
        }

        protected abstract void ReadData(string data);
        protected abstract void ParseData();

        protected virtual void ValidateData()
        {
            Console.WriteLine("  Validating data (default validation)");
        }

        protected abstract void SaveData();
    }
}
