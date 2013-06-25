using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.TreeTraversal
{
    public class Node<T>
    {
        public T Value { get; set; }

        public List<Node<T>> Children { get; set; }

        public Node<T> Parent { get; set; }

        public bool HasParent { get; set; }

        public Node(T value)
        {
            this.Value = value;
            this.Children = new List<Node<T>>();
        }


        public Node<T> GetNode(int index)
        {
            return this.Children[index];
        }
    }
}
