using System;
using System.Collections.Generic;
using System.Linq;

namespace HuffmanCompressor
{
    public class CharacterList
    {
        private List<(char, int)> charList { get; set; }

        public void CountCharacters(string text)
        {
            foreach (char c in text)
            {
                bool containsChar = charList.Any(c => c.Item1 == c)
            }
        }

        public void OrderDict()
        {
            
        }
    }
}