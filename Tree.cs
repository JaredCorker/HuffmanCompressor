using System;
using System.Collections.Generic;
using System.Linq;

namespace HuffmanCompressor
{
    public class Tree
    {
        public Node Root { get; set; }
        public void CreateTree(List<Node> nodes)
        {
            while (nodes.Count > 1)
            {
                Node last = nodes[nodes.Count - 1];
                Node secondLast = nodes[nodes.Count - 2];
                Node combind = new Node(last.Frequency + secondLast.Frequency, '\0', last, secondLast);
                nodes.RemoveRange(nodes.Count - 2, 2);
                nodes.Add(combind);
            
                nodes = nodes.OrderByDescending(x => x.Frequency).ToList();
            }

            Root = nodes[0];
        }
    }
}