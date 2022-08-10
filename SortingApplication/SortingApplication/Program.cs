namespace SortingApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fileName = new Generator().Generate(100);

            new Sorter().Sort(fileName, 10);
        }
    }
}