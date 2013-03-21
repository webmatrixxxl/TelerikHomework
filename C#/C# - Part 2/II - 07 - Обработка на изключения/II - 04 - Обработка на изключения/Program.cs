using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads an integer number and calculates and prints its square root.
//If the number is invalid or negative, print "Invalid number". In all cases finally print "Good bye". Use try-catch-finally.


namespace II___04___Обработка_на_изключения
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                uint number = uint.Parse(Console.ReadLine());

                Console.WriteLine(Math.Sqrt(number));
            }

            catch (ArgumentNullException)
            {
                Console.Error.WriteLine("Invalid number");
            }

            catch (FormatException)
            {
                Console.Error.WriteLine("Invalid number");
            }

            catch (OverflowException)
            {
                Console.Error.WriteLine("Invalid number");
            }

            finally
            {
                Console.WriteLine("Good bye!");
            }
        }
    }
}
