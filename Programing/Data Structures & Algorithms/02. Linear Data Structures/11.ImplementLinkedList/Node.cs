using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ImplementLinkedList
{
    public class Node
    {
        private object element;
        private Node next;

        public object Element
        {
            get { return element; }
            set { element = value; }
        }

        public Node Next
        {
            get { return next; }
            set { next = value; }
        }

        public Node(object element, Node prevNode)
        {
            this.element = element;
            prevNode.next = this;
        }

        public Node(object element)
        {
            this.element = element;
            next = null;
        }
    }
}
