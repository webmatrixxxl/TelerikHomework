using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//* Read in MSDN about the keyword event in C# and how to publish events. Re-implement the above using .NET
//events and following the best practices.

namespace _08.EventTimer
{

    public delegate void TimerDelegate(); // Delegate

    public class Timer : EventArgs
    {
        public event TimerDelegate TimeElapsed; // Link Delagate and event
        // This method repeat other method after some time in some duration
        public static void RepeatSomeMethod(TimerDelegate method, int seconds, long durationInSeconds)
        {
            long start = 0;
            while (start <= durationInSeconds)
            {
                method();
                Thread.Sleep(seconds * 1000);
                start += seconds;
            }

        }

      
        // The method which will use to repeat
        public static void Print()
        {
            Console.WriteLine("This text will repeat in a few seconds!");
        }

        static void Main()
        {
            Timer.RepeatSomeMethod(Print, 2, 10);
        }
    }
}
