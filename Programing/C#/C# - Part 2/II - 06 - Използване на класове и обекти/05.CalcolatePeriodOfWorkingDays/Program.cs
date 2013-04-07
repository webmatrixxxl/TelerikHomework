using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CalcolatePeriodOfWorkingDays
{
    class Program
    {
        static void Main()
        {

            DateTime currentDate = DateTime.Today;//current date

            Console.Write("Enter final date<YYYY.MM.DD>: ");
            string[] DataToString = Console.ReadLine().Split('.');
            int day = Convert.ToInt32(DataToString[2]);
            int month = Convert.ToInt32(DataToString[1]);
            int year = Convert.ToInt32(DataToString[0]);
            DateTime endDate = new DateTime(year, month, day);//end date

            int timeLenght = Math.Abs((currentDate - endDate).Days);//period length in days

            Console.WriteLine(CountWorkDays(currentDate, endDate, timeLenght));//call the method and see the result
        }
        static int CountWorkDays(DateTime cur, DateTime end, int len)
        {
            bool isPublicHoliday = false;//chek if the current day is a Public Holiday
            int countWorkDays = 0; //count the work days
            for (int i = 0; i < len; i++)
            {
                cur = cur.AddDays(1);//in every step we add one day to the current date
                if ((cur.DayOfWeek != DayOfWeek.Saturday) && (cur.DayOfWeek != DayOfWeek.Sunday))//chek if it is not weekend
                {
                    for (int j = 0; j < Holidays().Length; j++)//cycle to chek if the current day is a Public Holiday
                    {
                        if (cur == Holidays()[j])
                        {
                            isPublicHoliday = true;
                            break;
                        }
                    }
                    if (!isPublicHoliday)//if it is not holiday count one more work day
                    {
                        countWorkDays++;
                    }
                    isPublicHoliday = false;//restart the boolen expresiion
                }
            }
            return countWorkDays;
        }
        static DateTime[] Holidays()//shows the public holidays, but this is example and this dates are not true at all
        {
            DateTime[] holid = new DateTime[]
            {
                new DateTime(2013, 01, 30),
                new DateTime(2013, 02, 23),
                new DateTime(2013, 03, 30),
                new DateTime(2013, 05, 30),
                new DateTime(2013, 07, 30),
                new DateTime(2013, 11, 30),
                new DateTime(2013, 12, 30),
                new DateTime(2014, 01, 30),
                new DateTime(2014, 05, 30),
            };
            return holid;
        }
    }
}
