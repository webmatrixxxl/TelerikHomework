using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose what kind of variable you would like to enter.");
            Console.Write("For int press 1, for double - 2 and for string - 3: ");
            string userInput = Console.ReadLine();
            byte userChoice;
            bool check = byte.TryParse(userInput, out userChoice);
            bool isInputCorrect;
            if (check)
            {
                switch (userChoice)
                {
                    case 1:
                        Console.Write("Input integer value: ");
                        int a = int.Parse(Console.ReadLine());
                        a++;
                        Console.WriteLine(a);
                        break;
                    case 2:
                        Console.Write("Input double value: ");
                        double b = double.Parse(Console.ReadLine());
                        b++;
                        Console.WriteLine(b);
                        break;
                    case 3:
                        Console.Write("Input double value: ");
                        string c = Console.ReadLine();
                        c += "*";
                        Console.WriteLine(c);
                        break;
                }
            }
        }
    }
}
