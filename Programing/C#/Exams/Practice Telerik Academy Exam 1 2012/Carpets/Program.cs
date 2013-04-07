using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpets
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int p = N / 2;
            int counter = 0;
            int count = 0;
         

            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < N; i++)
            {
                for (int c = 1; c <= N; c++)
                {
                    

                    if ( (((c == N / 2 - i+counter) && c>counter & c<=N/2) || (c == N / 2 - i) || (c == (N / 2) + (N - i)-counter)  && (i<N-counter && c<=N-counter)))
                    {
                        Console.Write("/");

                    }

                    else if ((c == N / 2 + i + 1) || (c == ((N / 2)+1) - (N - i)))
                    {
                        Console.Write("\\");
                    }
                    else if ((c == N / 2 + i  || c == N / 2 - i + 1 && i > 0))
                    {
                        if (true)
                        {
                            
                        }
                        Console.Write(" ");
                        
                          
                        
                    }
                    else
                    {
                        
                            Console.Write(".");
                        
                      


                    }
                }

                Console.WriteLine(counter);


                if (i%2==1 && i<N/2)
                {
                    counter += 2;
                    count += 4;
                }
                if (i % 2 == 1 && i>=N/2-2)
                {
                    counter -= 2;
                    count -= 4;
                }



                if (p >= 0)
                {
                    p--;
                }
                if (p == 0 && i > N / 2)
                {
                    p++;
                }
            }
        }
    }
}

//if (c == p)
//{
//    Console.Write("/");
//}

//else if (c > p)
//{
//    if (counter > 0)
//    {
//        for (int m = 0; m < counter; m++)
//        {
//            Console.Write(" /");



//        }
//        break;
//    }

//}
//else
//{
//    Console.Write(".");
//}