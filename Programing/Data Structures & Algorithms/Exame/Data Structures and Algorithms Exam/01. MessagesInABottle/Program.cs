using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MessagesInABottle
{
    class Program
    {
        static List<KeyValuePair<char, string>> chiphers = new List<KeyValuePair<char, string>>();
        static string massage;

        static void Main(string[] args)
        {
            massage = Console.ReadLine();
            string chipher = Console.ReadLine();

            char key = '\0';
            StringBuilder value = new StringBuilder();

            for (int i = 0; i < chipher.Length; i++)
            {
                if (chipher[i] >= 'A' && chipher[i] <= 'Z')
                {
                    if (key != char.MinValue)
                    {
                        chiphers.Add(new KeyValuePair<char, string>(key, value.ToString()));
                        value.Clear();
                    }

                    key = chipher[i];
                }
                else
                {
                    value.Append(chipher[i]);
                }
            }

            if (key != char.MinValue)
            {
                chiphers.Add(new KeyValuePair<char, string>(key, value.ToString()));
                value.Clear();
            }

            Slove(0, new StringBuilder());
            Console.WriteLine(solutions.Count);

            solutions.Sort();

            foreach (var solution in solutions)
            {
                Console.WriteLine(solution);
            }
        }

        static int count = 0;
        static List<string> solutions = new List<string>();

        static void Slove(int secretMassageIndex, StringBuilder sb)
        {
            if (secretMassageIndex == massage.Length)
            {
                count++;
                solutions.Add(sb.ToString());
                
                return;
            }

            foreach (var chipher in chiphers )
            {
                if (massage.Substring(secretMassageIndex).StartsWith(chipher.Value))
                {
                    sb.Append(chipher.Key);
                    Slove(secretMassageIndex + chipher.Value.Length, sb);
                    sb.Length--;
                }
            }
        }
    }
}