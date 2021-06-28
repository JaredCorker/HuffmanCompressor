using System;

namespace HuffmanCompressor
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "aaaaabbbbcccde";
            CharacterList cl = new CharacterList();
            cl.CountCharacters(text);
            foreach (Node n in cl.CharList)
            {
                Console.WriteLine("{0}: {1}", n.Character, n.Frequency);
            }
            Tree t = new Tree();
            t.CreateTree(cl.CharList);
            Console.WriteLine("{0}", t.Root.Frequency);
            t.TraverseTree(t.Root);
            Console.WriteLine("Path to {0}", t.GetNode("11011"));
        }
    }
}