using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//Using delegates write a class Timer that has can execute certain method at each t seconds.


namespace _07.DelegatesClassTimerExecuteEachTSecund
{

    public delegate void TimerDelegate(); // Declare delegate

    public class Timer
    {

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
