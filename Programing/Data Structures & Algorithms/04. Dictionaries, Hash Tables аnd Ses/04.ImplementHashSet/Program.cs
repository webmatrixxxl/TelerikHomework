using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ImplementHashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashedSet<int> set = new HashedSet<int>(new int[] { 111, 1, 3, 5, 7, 12 });
            Console.WriteLine(set.Count);

            set.Add(122);

            Console.WriteLine(set.Find(122));
            Console.WriteLine(set.Count);
            set.Remove(122);
            Console.WriteLine(set.Count);

            foreach (var item in set)
            {
                Console.WriteLine(item);
            }

            HashedSet<int> newSet = new HashedSet<int>(new int[] { 1, 3, 5, 7, 12, 2222 });

            newSet.UnionWhith(set);

            foreach (var item in newSet)
            {
                Console.WriteLine(item);
            }
        }
    }
}
