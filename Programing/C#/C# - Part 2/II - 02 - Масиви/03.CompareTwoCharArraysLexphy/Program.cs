using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CompareTwoArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrySize = 5;                            //Set size of to arrays that elements will be compeard
            char[] ary = new char[arrySize];             //Initialise first array with name ary
            char[] ary2 = new char[arrySize];            //Initialise second array with name ary2
            for (int i = 0; i < arrySize; i++)         //Loop through each element to read values form console.
            {
                Console.Write("Enter ArrayA[{0}]: ", i);  //Output nasage to start entering arry elements.
                ary[i] = char.Parse(Console.ReadLine());  //Each element of array takse value form console
                Console.Write("Enter ArrayB[{0}]: ", i);
                ary2[i] = char.Parse(Console.ReadLine()); //Each element of ary takse value form console

            }

            for (int i = 0; i < arrySize; i++) //Loop again through each element of array and output results of compartment
            {

                if (ary[i] == ary2[i]) //Compare velues, element by element
                {
                    Console.WriteLine("ArrayA[{0}]=ArrayB{0}={1}", i, ary[i]); //Output on console
                }
                else if (ary[i] > ary2[i])
                {
                    Console.WriteLine("ArrayA[{0}]>ArrayB{0}", i);
                }
                else if (ary[i] < ary2[i])
                {
                    Console.WriteLine("ArrayA[{0}]<ArrayB{0}", i);
                }

            }
        }
    }
}
