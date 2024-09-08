using DesignPatterns.Creational.FactoryMethod.Products;

namespace DesignPatterns.Creational.FactoryMethod.Creators
{
    public class ResumeCreator : DocumentCreator
    {
        public override Document CreateDocument() => new Resume();
    }
}