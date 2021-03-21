using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3
{
    class WordCalculator
    {
        public static List<WordOccurrence> CalculateOccurrences(List<string> Words)
        {
            List<WordOccurrence> totalOccurrences = new List<WordOccurrence>();
            bool found = false;
            int count = 0;

            if (Words.Count == 0)
            {
                throw new Exception("Invalid Input");
            }
            else
            {
                for (int i = 0; i < Words.Count; i++)
                {
                    foreach (var wordOccurrence in totalOccurrences)
                    {
                        if (wordOccurrence.Word.Equals(Words[i]))
                        {
                            found = true;
                        }
                    }

                    if (!found)
                    {
                        for (int j = i; j < Words.Count; j++)
                        {
                            if (Words[i].Equals(Words[j], StringComparison.InvariantCultureIgnoreCase))
                            {
                                count++;
                            }
                        }

                        WordOccurrence occurrence = new WordOccurrence(Words[i], count);
                        totalOccurrences.Add(occurrence);
                    }
                }
            }

            return totalOccurrences;
        }
    }
}
