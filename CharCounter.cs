using System;
using System.Collections.Generic;
using System.Text;

namespace Studio2
{
    class CharCounter
    {
        public static void CountInput(string input)
        {
            char[] charArr = input.ToLower().ToCharArray();
            Dictionary<char, int> counts = new Dictionary<char, int>();
            
            foreach(char c in charArr)
            {
                if (Char.IsLetter(c))
                {
                    if (counts.ContainsKey(c))
                    {
                        counts[c]++;
                    } 
                    else
                    {
                        counts.Add(c, 1);
                    }
                }
            }

            foreach(KeyValuePair<char, int> pair in counts)
            {
                Console.WriteLine(pair.Key + ": " + pair.Value);
            }
            Console.WriteLine();
        }
    }
}
