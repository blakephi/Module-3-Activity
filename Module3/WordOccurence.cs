using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3
{
    class WordOccurrence
    {
        private string word;
        private int count;

        public WordOccurrence(string _word, int _count)
        {
            word = _word;
            count = _count;
        }

        public string Word { get => word; set => word = value; }
        public int Count { get => count; set => count = value; }


        public override string ToString()
        {
            return "Word: " + Word + ", Occurrence: " + Count + "\n";
        }
    }
}
