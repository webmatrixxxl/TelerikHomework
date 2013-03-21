using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.FindsLargestAreOfEqualNeighborElements
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public class BinaryTreeNode
        {
            public BinaryTreeNode Left { get; set; }

            public BinaryTreeNode Right { get; set; }

            public int Data { get; set; }
        }

        public class DepthFirstSearch
        {
            private Stack<BinaryTreeNode> _searchStack;
            private BinaryTreeNode _root;

            public DepthFirstSearch(BinaryTreeNode rootNode)
            {
                _root = rootNode;
                _searchStack = new Stack<BinaryTreeNode>();
            }

            public bool Search(int data)
            {
                BinaryTreeNode _current;
                _searchStack.Push(_root);
                while (_searchStack.Count != 0)
                {
                    _current = _searchStack.Pop();
                    if (_current.Data == data)
                    {
                        return true;
                    }
                    else
                    {
                        _searchStack.Push(_current.Right);
                        _searchStack.Push(_current.Left);
                    }
                }
                return false;
            }
        }
    }
}
