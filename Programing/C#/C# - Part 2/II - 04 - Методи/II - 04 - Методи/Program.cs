using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”).
//Write a program to test this method.


namespace II___04___Методи
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter name: ");
            Hello(Console.ReadLine());
        }
        static void Hello(string name)
        {
            Console.WriteLine("Hello "+ name);
        }
    }
}
