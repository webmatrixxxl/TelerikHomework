using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FriendsInNeed
{
    public class Program
    {
        static void Main()
        {
            //      5 8 2
            //      1 2
            //      1 2 5
            //      4 1 2
            //      1 3 1
            //      3 4 4
            //      4 5 1
            //      2 4 3
            //      5 2 1
            //      2 3 20


            string[] inputNumbers = Console.ReadLine().Split(' ');

            int pointsNumber = int.Parse(inputNumbers[0]);
            int streetsNumbers = int.Parse(inputNumbers[1]);
            int hospitalNumbers = int.Parse(inputNumbers[2]);

            string[] allHospitals = Console.ReadLine().Split(' ');

            Dictionary<Node, List<Connection>> graph = new Dictionary<Node, List<Connection>>();
            Dictionary<int, Node> allNodes = new Dictionary<int, Node>();

            for (int i = 0; i < streetsNumbers; i++)
            {
                string[] currentStreet = Console.ReadLine().Split(' ');
                int firstNode = int.Parse(currentStreet[0]);
                int secondNode = int.Parse(currentStreet[1]);
                int distance = int.Parse(currentStreet[2]);

                if (!allNodes.ContainsKey(firstNode))
                {
                    allNodes.Add(firstNode, new Node(firstNode));
                }

                if (!allNodes.ContainsKey(secondNode))
                {
                    allNodes.Add(secondNode, new Node(secondNode));
                }

                Node firstNodeObject = allNodes[firstNode];
                Node secondNodeObject = allNodes[secondNode];

                if (!graph.ContainsKey(firstNodeObject))
                {
                    graph.Add(firstNodeObject, new List<Connection>());
                }

                if (!graph.ContainsKey(secondNodeObject))
                {
                    graph.Add(secondNodeObject, new List<Connection>());
                }

                graph[firstNodeObject].Add(new Connection(secondNodeObject, distance));
                graph[secondNodeObject].Add(new Connection(firstNodeObject, distance));

            }

            long result = long.MaxValue;

            for (int i = 0; i < allHospitals.Length; i++)
            {
                int currentHosptial = int.Parse(allHospitals[i]);
                allNodes[currentHosptial].IsHospital = true;
            }

            for (int i = 0; i < allHospitals.Length; i++)
            {
                int currentHosptial = int.Parse(allHospitals[i]);

                DijkstraAlgorithm(graph, allNodes[currentHosptial]);

                long temporarySum = 0;

                foreach (var node in allNodes)
                {
                    if (!node.Value.IsHospital)
                    {
                        temporarySum += node.Value.DijkstraDistance;
                    }
                }

                if (temporarySum < result)
                {
                    result = temporarySum;
                }
            }

            Console.WriteLine(result);
        }

        static void DijkstraAlgorithm(Dictionary<Node, List<Connection>> graph, Node sorce)
        {
            PriorityQueue<Node> queue = new PriorityQueue<Node>();

            foreach (var node in graph)
            {
                node.Key.DijkstraDistance = long.MaxValue;
            }

            sorce.DijkstraDistance = 0;
            queue.Enqueue(sorce);

            while (queue.Count != 0)
            {
                Node currentNode = queue.Dequeue();

                if (currentNode.DijkstraDistance == long.MaxValue)
                {
                    break;
                }

                foreach (var connection in graph[currentNode])
                {
                    var potDistance = currentNode.DijkstraDistance + connection.Distance;

                    if (potDistance < connection.ToNode.DijkstraDistance)
                    {
                        connection.ToNode.DijkstraDistance = potDistance;
                        queue.Enqueue(connection.ToNode);
                    }
                }
            }
        }
    }

    public class Node : IComparable
    {
        public int Id { get; set; }
        public long DijkstraDistance { get; set; }
        public bool IsHospital { get; set; }

        public Node(int id)
        {
            this.Id = id;
            this.IsHospital = false;
        }

        public int CompareTo(object obj)
        {
            return this.DijkstraDistance.CompareTo((obj as Node).DijkstraDistance);
        }
    }

    public class Connection
    {
        public Node ToNode { get; set; }
        public long Distance { get; set; }

        public Connection(Node toNode, long distance)
        {
            this.ToNode = toNode;
            this.Distance = distance;
        }
    }

    public class PriorityQueue<T> where T : IComparable
    {
        private T[] heap;
        private int index;

        public int Count
        {
            get
            {
                return this.index - 1;
            }
        }

        public PriorityQueue()
        {
            this.heap = new T[16];
            this.index = 1;
        }

        public void Enqueue(T element)
        {
            if (this.index >= this.heap.Length)
            {
                IncreaseArray();
            }

            this.heap[this.index] = element;

            int childIndex = this.index;
            int parentIndex = childIndex / 2;
            this.index++;

            while (parentIndex >= 1 && this.heap[childIndex].CompareTo(this.heap[parentIndex]) < 0)
            {
                T swapValue = this.heap[parentIndex];
                this.heap[parentIndex] = this.heap[childIndex];
                this.heap[childIndex] = swapValue;

                childIndex = parentIndex;
                parentIndex = childIndex / 2;
            }
        }

        public T Dequeue()
        {
            T result = this.heap[1];

            this.heap[1] = this.heap[this.Count];
            this.index--;

            int rootIndex = 1;

            int minChild;

            while (true)
            {
                int leftChildIndex = rootIndex * 2;
                int rightChildIndex = rootIndex * 2 + 1;

                if (leftChildIndex > this.index)
                {
                    break;
                }
                else if (rightChildIndex > this.index)
                {
                    minChild = leftChildIndex;
                }
                else
                {
                    if (this.heap[leftChildIndex].CompareTo(this.heap[rightChildIndex]) < 0)
                    {
                        minChild = leftChildIndex;
                    }
                    else
                    {
                        minChild = rightChildIndex;
                    }
                }

                if (this.heap[minChild].CompareTo(this.heap[rootIndex]) < 0)
                {
                    T swapValue = this.heap[rootIndex];
                    this.heap[rootIndex] = this.heap[minChild];
                    this.heap[minChild] = swapValue;

                    rootIndex = minChild;
                }
                else
                {
                    break;
                }
            }

            return result;
        }

        public T Peek()
        {
            return this.heap[1];
        }

        private void IncreaseArray()
        {
            T[] copiedHeap = new T[this.heap.Length * 2];

            for (int i = 0; i < this.heap.Length; i++)
            {
                copiedHeap[i] = this.heap[i];
            }

            this.heap = copiedHeap;
        }
    }
}
