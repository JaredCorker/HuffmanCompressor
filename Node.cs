using System;

namespace HuffmanCompressor
{
    public class Node
    {
        public int Frequency { get; set; }
        public char Character { get; set; }
        public Node LeftChild { get; set; }
        public Node RightChild { get; set; }

        public Node(int frequency, char character, Node leftChild, Node rightChild)
        {
            Frequency = frequency;
            Character = character;
            LeftChild = leftChild;
            RightChild = rightChild;
        }
    }
}