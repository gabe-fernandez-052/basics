namespace DesignPatterns.Creational.FactoryMethod.Products
{
    public abstract class Document
    {
        protected List<Page> pages = [];

        public Document() => CreatePages();

        public List<Page> Pages => pages;

        public abstract void CreatePages();
    }
}