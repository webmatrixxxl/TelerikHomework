using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxPath
{
    class Program
    {
        static long maxSum = 0;
        static HashSet<Node<int>> usedNodes = new HashSet<Node<int>>();

        private static void DFS(Node<int> node, long currentSum)
        {
            currentSum += node.Value;
            usedNodes.Add(node);

            for (int i = 0; i < node.CountOfChildren; i++)
            {
                if (usedNodes.Contains(node.GetNode(i)))
                {
                    continue;
                }

                DFS(node.GetNode(i), currentSum);
            }

            if (node.CountOfChildren == 1 && currentSum > maxSum)
            {
                maxSum = currentSum;
            }
        }

        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            Dictionary<int, Node<int>> nodes = new Dictionary<int, Node<int>>();
            int maxNode = 0;

            for (int i = 0; i < N - 1; i++)
            {
                string connection = Console.ReadLine();

                string[] separatedConnection = connection.Split
                    (new char[] { '(', '<', '-', ')', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                int parent = int.Parse(separatedConnection[0]);
                int child = int.Parse(separatedConnection[1]);

                Node<int> parentNode;
                Node<int> childNode;

                if (nodes.ContainsKey(parent))
                {
                    parentNode = nodes[parent];
                }
                else
                {
                    parentNode = new Node<int>(parent);
                    nodes.Add(parent, parentNode);
                }

                if (nodes.ContainsKey(child))
                {
                    childNode = nodes[child];
                }
                else
                {
                    childNode = new Node<int>(child);
                    nodes.Add(child, childNode);
                }

                parentNode.AddChild(childNode);
                childNode.AddChild(parentNode);

                if (parent > maxNode)
                {
                    maxNode = parent;
                }

                if (child > maxNode)
                {
                    maxNode = child;
                }
            }

            foreach (var node in nodes)
            {
                if (node.Value.CountOfChildren == 1)
                {
                    usedNodes.Clear();
                    DFS(node.Value, 0);
                }
            }

            Console.WriteLine(maxSum);
        }
    }
}
