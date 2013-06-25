using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxPath
{
    public class Node<T>
    {
        public T Value { get; set; }
        private List<Node<T>> Children { get; set; }
        public bool HasParent { get; set; }

        public Node(T value)
        {
            this.Value = value;
            this.Children = new List<Node<T>>();
        }

        public int CountOfChildren
        {
            get
            {
                return this.Children.Count;
            }
        }

        public void AddChild(Node<T> child)
        {
            child.HasParent = true;
            Children.Add(child);
        }

        public Node<T> GetNode(int index)
        {
            return this.Children[index];
        }
    }

}
