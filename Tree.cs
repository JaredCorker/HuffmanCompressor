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

        public char TraverseTree(Node node)
        {
            if (node.LeftChild == null && node.RightChild == null)
            {
                Console.WriteLine("{0}", node.Character);
                return node.Character; 
            }
            else
            {
                if (node.LeftChild != null)
                {
                    TraverseTree(node.LeftChild);
                }
                
                if (node.RightChild != null)
                {
                    TraverseTree(node.RightChild);
                }
                return '\0';
            }
        }

        public char GetNode(string bits)
        {
            Node currentNode = Root;
            foreach (char bit in bits)
            {
                if (bit == '0')
                {
                    if (currentNode.LeftChild == null)
                    {
                        return '\0';
                    }
                    currentNode = currentNode.LeftChild;
                }
                else
                {
                    if (currentNode.RightChild == null)
                    {
                        return '\0';
                    }
                    currentNode = currentNode.RightChild;
                }
            }

            return currentNode.Character;
        }
    }
}