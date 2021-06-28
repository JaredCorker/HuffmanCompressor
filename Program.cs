using System;

namespace HuffmanCompressor
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "My name is jared";
            CharacterList cl = new CharacterList();
            cl.CountCharacters(text);
            foreach (Node n in cl.CharList)
            {
                Console.WriteLine("{0}: {1}", n.Character, n.Frequency);
            }
        }
    }
}
