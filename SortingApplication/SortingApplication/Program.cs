using System.Diagnostics;

namespace SortingApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fileName = new Generator().Generate(20_000_000);

            var sw = Stopwatch.StartNew();

            new Sorter().Sort(fileName, 100_000);

            sw.Stop();
            Console.WriteLine(sw.Elapsed);
        }
    }
}