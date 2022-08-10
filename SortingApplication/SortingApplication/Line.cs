using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApplication
{
    internal class Line : IComparable<Line>
    {
        public Line(string line)
        {
            int pos = line.IndexOf(".");
            Number = int.Parse(line.Substring(0, pos));
            Word = line.Substring(pos + 2);
        }

        public int CompareTo(Line other)
        {
            var result = Word.CompareTo(other.Word);
            if (result != 0)
                return result;

            return Number.CompareTo(other.Number);
        }

        public string Build()
        {
            return Number + ". " + Word;
        }

        public int Number { get; set; }
        public string Word { get; set; }
    }
}
