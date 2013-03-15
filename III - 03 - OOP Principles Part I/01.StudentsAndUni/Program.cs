using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.StudentsAndUni
{
    class Program
    {
        static void Main(string[] args)
        {
            Disciplines Biologia = new Disciplines("Biologia", 1, 5);
            Disciplines Himiq = new Disciplines("Himiq", 1, 5);
            Disciplines Fizika = new Disciplines("Fizika", 1, 5);

            Teachers Vunderkin = new Teachers("Go6o Petrov-altshaimera");
            Students Pe6oTupoto = new Students(1,"Pe6o Tupoto");

            Classes a = new Classes("10A",Vunderkin,Pe6oTupoto);

            List<Students> students = new List<Students>();
        }
    }
}
