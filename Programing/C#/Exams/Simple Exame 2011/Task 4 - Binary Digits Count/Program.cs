using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4___Binary_Digits_Count
{
    class Program
    {
        static void Main(string[] args)
        {

            int B = int.Parse(Console.ReadLine());
            uint N = uint.Parse(Console.ReadLine());
            int i = 0;
            for (uint c = N; c > 0; c--)
            {
                uint n = uint.Parse(Console.ReadLine());
                
                while (n!=0)
                {
                    
                    uint p = n & 1;
                    if (p == B)
                    {
                        i++;
                    }
                    n >>= 1;      

                }
                Console.WriteLine(i);
                i = 0;
               
            }

            
        }
    }
}
