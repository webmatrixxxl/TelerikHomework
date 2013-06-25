using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  Примерен вход
//  4
//  1
//  1
//  2
//  2	

//  Примерен изход	5	
//  Обяснение:
//  Ако има 2 заека с лилав и 3 заека с черен цвят (вижте картинката от условието),
//  то тогава котаракът получава  отговорите, описани в примерния вход след като попита 4-ри от тях.

namespace _04.Colorfull_Rabits
{
    class Program
    {
        private static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int[] replies = new int[count];

            for (int i = 0; i < count; i++)
            {
                replies[i] = int.Parse(Console.ReadLine());
            }

            int answer = getMinimum(replies);

            Console.WriteLine(answer);
        }

        private static int getMinimum(int[] replies)
        {
            int[] cache = new int[1000002];

            for (int i = 0; i < replies.Length; i++)
            {
                cache[replies[i] + 1]++;
            }

            int rabbits = 0;

            for (int i = 0; i < cache.Length; i++)
            {
                if (cache[i] == 0)
                {
                    continue;
                }

                if (cache[i] <= i)
                {
                    rabbits += i;
                }
                else
                {
                    rabbits += (int)Math.Ceiling((double)cache[i] / i) * i;
                }
            }

            return rabbits;
        }
    }
}
