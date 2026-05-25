using DesignPatterns.Behavioral.Visitor.Element;

namespace DesignPatterns.Behavioral.Visitor.Visitor
{
    public class DisplayVisitor : IVisitor
    {
        public void Visit(FileElement file)
        {
            Console.WriteLine($"  [File] {file.Name} ({file.SizeKb} KB)");
        }

        public void Visit(DirectoryElement directory)
        {
            Console.WriteLine($"  [Dir]  {directory.Name}/ ({directory.FileCount} files)");
        }
    }
}
