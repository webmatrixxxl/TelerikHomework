using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carpet2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int row = 0;
            int a = 0;
            int b = 0;
            int count = 1;
            int countR = 0;
            for (int i = 0; i < N * N; i++)
            {
                if (row % 2 == 0 && (row + 1) * N - N / 2 == i)
	{
		 
	}
               
                if ((i % N == 0) && i!=0)
                {

                    Console.WriteLine(i);
                    row++;
                }
                if (row % 2 == 0 && (row + 1) * N - N / 2 == i && row < N / 2)
                {
                    Console.Write("\\");
                }
                else if ((((row+1)*N-N/2)-row-count==i && row<N/2) || row%2==0 && (row+1)*N-N/2-1==i && row<N/2)
                {
                    Console.Write("/");
                    if (row > 2 && row % 2 == 00)
                    {
                        a = 1;
                    }
                }
                
                else
                {
                    if (a==1)
                    {
                        
                    }
                    Console.Write(".");
                }


              

            }
        }
    }
}
