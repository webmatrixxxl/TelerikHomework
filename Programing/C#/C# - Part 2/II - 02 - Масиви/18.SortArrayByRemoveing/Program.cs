using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.SortArrayByRemoveing
{
    class Program
    {
        static void Main(string[] args)
        {
            int input=8;
            List<int> arr = new List<int>();
            for (int i = 0; i < 9; i++)
            {
               
                arr.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i <input; i++)
            {
                if (arr[i]>arr[i+1])
                {
                    arr.Remove(i);
                    input--;
                }
                
            }
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
