using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  Define abstract class Human with first name and last name. Define new class Student which is
//  derived from Human and has new field – grade. Define class Worker derived from Human with 
//  new property WeekSalary and WorkHoursPerDay and method MoneyPerHour() that returns money
//  earned by hour by the worker. Define the proper constructors and properties for this
//  hierarchy. Initialize a list of 10 students and sort them by grade in ascending order 
//  (use LINQ or OrderBy() extension method). Initialize a list of 10 workers and sort them
//  by money per hour in descending order. Merge the lists and sort them by first name and
//  last name.


namespace HumanWorkerMoney
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
        {
            new Student("Тошо", "Петков", "08 А"),
            new Student("Пешо", "Петков", "08 А"),
            new Student("Гошо", "Петков", "10 А"),
            new Student("Михо", "Петков", "10 А"),
            new Student("Александър", "Петков", "10 Б"),
            new Student("Клександър", "Петков", "08 Б"),
            new Student("Венцисалво", "Петков", "10 Б"),
            new Student("Владислав", "Петков", "12 А"),
            new Student("Гошо", "Петков", "12 А"),
            new Student("Преслава", "Петкова", "12 Б"),
            new Student("Филип", "Петков", "12 Б")
        };

            List<Worker> workers = new List<Worker>()
        {
            new Worker("Водолей", "Петков", 700, 26),
            new Worker("Асен", "Петков", 730, 26),
            new Worker("Гошо", "Петков", 233, 25),
            new Worker("Пресла", "Петкова", 971, 45),
            new Worker("Владислав", "Петков", 2611, 44),
            new Worker("Венцислав", "Петков", 1731, 52),
            new Worker("Пешо", "Петков", 1722, 36),
            new Worker("Антоний", "Петков", 172, 35),
            new Worker("Преслав", "Петков", 571, 43),
            new Worker("Гошо", "Петков", 1081, 51),
            new Worker("Филип", "Петков", 1071, 35)
        };
            Console.WriteLine();
            Console.WriteLine(workers[0] + " First worker Test");
            Console.WriteLine();

            {
                students.OrderBy(
                   student => student.grade
                ).Print();

                workers.OrderByDescending(
                    worker => worker.GetMoneyPerHour()
                ).Print();
            }

         
        }
    }
}
