using System;
using System.Collections.Generic;
using System.Linq;

namespace HuffmanCompressor
{
    public class CharacterList
    {
        public List<Node> CharList { get; set; }

        public CharacterList()
        {
            CharList = new List<Node>();
        }

        public void CountCharacters(string text)
        {
            if (text != null)
            {
                foreach (char c in text)
                {
                    bool containsChar = CharList.Any(x => x.Character == c);
                    if (containsChar)
                    {
                        foreach (Node n in CharList)
                        {
                            if (n.Character == c)
                            {
                                n.Frequency += 1;
                            }
                        }
                    }
                    else
                    {
                        Node n = new Node(1, c, null, null);
                        CharList.Add(n);
                    }
                }

                CharList = CharList.OrderByDescending(x => x.Frequency).ToList();
            }
        }
    }
}