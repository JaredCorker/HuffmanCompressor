using System;

namespace HuffmanCompressor
{
    public class Node
    {
        private int Frequency { get; set; }
        private char Character { get; set; }
        private Node LeftChild { get; set; }
        private Node RightChild { get; set; }

        public Node(int frequency, char character, Node leftChild, Node rightChild)
        {
            Frequency = frequency;
            Character = character;
            LeftChild = leftChild;
            RightChild = rightChild;
        }
    }
}