using System;
using System.Linq;

namespace _11.ImplementLinkedList
{
    public class DynamicList
    {
        public DynamicList()
        {
            this.head = null;
            this.tail = null;
            this.count = 0;
        }
       
        private Node head;
        private Node tail;
        private int count;

        /// <summary>
        /// Add element at the end of the list
        /// </summary>
        /// <param name="item">The element you want to add</param>
        public void Add(object item)
        {
            if (head == null)
            {
                // We have empty list
                head = new Node(item);
                tail = head;
            }
            else
            {
                // We have non-empty list
                Node newNode = new Node(item, tail);
                tail = newNode;
            }

            count++;
        }

        /// <summary>
        /// Removes and returns element on the specific index
        /// </summary>
        /// <param name="index">
        /// The index of the element you want to remove
        /// </param>
        /// <returns>The removed element</returns>
        /// <exception cref="System.ArgumentOutOfRangeException">Index is invalid</exception>
        public object Remove(int index)
        {
            if (index >= count || index < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid index: " + index);
            }

            // Find the element at the specified index
            int currentIndex = 0;
            Node currentNode = head;
            Node prevNode = null;

            while (currentIndex < index)
            {
                prevNode = currentNode;
                currentNode = currentNode.Next;
                currentIndex++;
            }

            // Remove the element
            count--;

            if (count == 0)
            {
                head = null;
            }

            else if (prevNode == null)
            {
                head = currentNode.Next;
            }
            else
            {
                prevNode.Next = currentNode.Next;
            }

            // Find last element
            Node lastElement = null;

            if (this.head != null)
            {
                lastElement = this.head;

                while (lastElement.Next != null)
                {
                    lastElement = lastElement.Next;
                }
            }

            tail = lastElement;

            return currentNode.Element;
        }

        /// <summary>
        /// Removes the specified item and return its index
        /// </summary>
        /// <param name="item">The item for removal</param>
        /// <returns>The index of the element or -1 if does not exist</returns>
        public int Remove(object item)
        {
            // Find the element containing searched item
            int currentIndex = 0;
            Node currentNode = head;
            Node prevNode = null;

            while (currentNode != null)
            {
                if ((currentNode.Element != null &&
               currentNode.Element.Equals(item)) ||
                   (currentNode.Element == null) &&
                                 (item == null))
                {
                    break;
                }

                prevNode = currentNode;
                currentNode = currentNode.Next;
                currentIndex++;
            }

            if (currentNode != null)
            {
                // Element is found in the list. Remove it
                count--;

                if (count == 0)
                {
                    head = null;
                }
                else if (prevNode == null)
                {
                    head = currentNode.Next;
                }

                else
                {
                    prevNode.Next = currentNode.Next;
                }

                // Find last element
                Node lastElement = null;

                if (this.head != null)
                {
                    lastElement = this.head;

                    while (lastElement.Next != null)
                    {
                        lastElement = lastElement.Next;
                    }
                }

                tail = lastElement;

                return currentIndex;
            }
            else
            {
                // Element is not found in the list
                return -1;
            }
        }

        /// <summary>
        /// Searches for given element in the list
        /// </summary>
        /// <param name="item">The item you are searching for</param>
        /// <returns>
        /// the index of the first occurrence of the element
        /// in the list or -1 when not found
        /// </returns>
        public int IndexOf(object item)
        {
            int index = 0;
            Node current = head;

            while (current != null)
            {
                if ((current.Element != null &&
                    current.Element == item) ||
                   (current.Element == null) &&
                             (item == null))
                {
                    return index;
                }

                current = current.Next;
                index++;
            }

            return -1;
        }

        /// <summary>
        /// Check if the specified element exists in the list
        /// </summary>
        /// <param name="item">The item you are searching for</param>
        /// <returns>
        /// True if the element exists or false otherwise
        /// </returns>
        public bool Contains(object item)
        {
            int index = IndexOf(item);
            bool found = (index != -1);

            return found;
        }

        /// <summary>
        /// Gets or sets the element on the specified position
        /// </summary>
        /// <param name="index">
        /// The position of the element [0 … count-1]
        /// </param>
        /// <returns>The object at the specified index</returns>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Index is invalid
        /// </exception>
        public object this[int index]
        {
            get
            {
                if (index >= count || index < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid index: " + index);
                }

                Node currentNode = this.head;

                for (int i = 0; i < index; i++)
                {
                    currentNode = currentNode.Next;
                }

                return currentNode.Element;
            }

            set
            {
                if (index >= count || index < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid index: " + index);
                }

                Node currentNode = this.head;

                for (int i = 0; i < index; i++)
                {
                    currentNode = currentNode.Next;
                }

                currentNode.Element = value;
            }
        }

        /// <summary>
        /// Gets the number of elements in the list
        /// </summary>
        public int Count
        {
            get
            {
                return count;
            }
        }
    }
}