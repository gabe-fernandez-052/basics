using DesignPatterns.Creational.FactoryMethod.Products;

namespace DesignPatterns.Creational.FactoryMethod.Creators
{
    public class ReportCreator : DocumentCreator
    {
        public override Document CreateDocument() => new Report();
    }
}