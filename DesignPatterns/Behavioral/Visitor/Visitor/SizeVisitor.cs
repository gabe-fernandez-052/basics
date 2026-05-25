using DesignPatterns.Behavioral.Visitor.Element;

namespace DesignPatterns.Behavioral.Visitor.Visitor
{
    public class SizeVisitor : IVisitor
    {
        public int TotalSize { get; private set; }

        public void Visit(FileElement file)
        {
            TotalSize += file.SizeKb;
            Console.WriteLine($"  File '{file.Name}': {file.SizeKb} KB");
        }

        public void Visit(DirectoryElement directory)
        {
            Console.WriteLine($"  Directory '{directory.Name}': size not tracked");
        }
    }
}
