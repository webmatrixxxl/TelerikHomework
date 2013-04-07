using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a string, reverses it and prints the result at the console.
//Example: "sample"  "elpmas".


namespace II___09___Стрингове_и_текстообработка
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "sample";
            char[] strArr = str.ToCharArray();
            Array.Reverse(strArr);
            Console.WriteLine(strArr);

        }
    }
}
