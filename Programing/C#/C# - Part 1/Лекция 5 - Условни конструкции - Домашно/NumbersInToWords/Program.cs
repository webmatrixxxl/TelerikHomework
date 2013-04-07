using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersInToWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] num = { "Нула", "Едно", "Две", "Три", "Четири", "Пет", "Шест", "Седем", "Осем", "Девет", "Десет", "Еди", "Два", "Сто", "ста" };
            string na = "на";
            string and = "и";
            string tin = "тин";
            Console.Write("Въведете число: ");

            int i = int.Parse(Console.ReadLine());
            if (i<=999 && i>=0)
            {


                if (i >= 100) //Check if input is bigger then 100
                {


                    if (i / 100 == 1) //Check if input = 100 and use it to print all numbers form 100 to 199
                    {
                        Console.Write("{0} ", num[13]); //Сто
                    }
                    else // If input is bigger then 100 
                    {
                        if (i >= 200 && i < 400) // Check if input is between 200 and 399 and print hundreds
                        {
                            Console.Write("{0} ", num[i / 100] + num[14]); //Две + ста, три + ста
                        }
                        else // If input is between 400 and 999 and print hundreds
                        {

                            Console.Write("{0} ", num[i / 100] + num[13] + tin); //Четиристотин, пет сто тин, шест сто тин .....
                        }
                    }

                    if (i / 100.0 != i / 100) // Check if there are any tens and units. If no stop printing
                    {

                        if (i % 100 > 10 && i % 100 < 20) // Check if tens are between 10 and 20
                        {
                            if (i % 100 > 10 && i % 100 <= 12) // Check if input tens is > 10 for 11 and 12 cases 
                            {
                                Console.WriteLine("{0} {1}", and, num[i % 100] + na + num[10]); //ЕДИН + на + десетр, ДВА + на + десет,....
                            }
                            else
                            {
                                Console.WriteLine("{0} {1}{2}", and, num[i % 100 % 10], na + num[10]); // три+на+десет, четири + на + десет,....
                            }
                        }

                        else
                        {
                            if (i % 100 >= 20 && i % 100 < 30) // Check if number is between 20 and 30
                            {
                                if (i % 100 % 10 == 0)
                                {
                                    Console.WriteLine("{0}", num[12] + num[10]); //сто ДВА + десет и едно, три + ста ДВА + десет и две........

                                }
                                else
                                {
                                    Console.WriteLine("{0} {1} {2}", num[12] + num[10], and, num[i % 100 % 10]); //сто ДВА + десет и едно, три + ста ДВА + десет и две........
                                }

                            }
                            else if ((i % 100 % 10 != 0) && (i % 10 / 10 != 0)) // Check if units != 0 and
                            {
                                Console.WriteLine("{0} {1} {2}", num[i % 100 / 10] + num[10], and, num[i % 100 % 10]); // три + ста четири + десет и пет,  осем + стотин четири + десет и две
                            }
                            else if (i % 100 / 10 == 0)
                            {
                                Console.WriteLine("{0} {1}", and, num[i % 100]); // три + ста четири + десет и пет,  осем + стотин четири + десет и две

                            }
                            else if ((i % 100 / 10 > 0) && (i % 100 % 10 == 0))
                            {
                                if ((i % 100 / 10 == 1) && (i % 100 % 10 == 0))
                                {
                                    Console.WriteLine("{0} {1}", and, num[10]);

                                }
                                else
                                {
                                    Console.WriteLine("{0} {1}", and, num[i % 100 / 10] + num[10]);
                                }
                            }
                            else
                            {
                                Console.WriteLine("{0} {1} {2}", num[i % 100 / 10] + num[10], and, num[i % 100 % 10]); // три + ста четири + десет,  осем + стотин четири + десет
                            }

                        }

                    }
                }
                if (i < 100 && i > 19) // If input is lower then 100
                {


                    if (i > 20 && i < 30) //  Check if input is between 20 and 30
                    {
                        Console.Write("{0} ", num[12] + num[10]); // ДВА + десет

                    }
                    else
                    {
                        Console.Write("{0} ", num[i / 10] + num[10]); //три + десет, осем + десет

                    }

                    if (i / 10.0 != i / 10) // Check if units != 0 10,20,30,40..... and print units
                    {
                        Console.WriteLine("{0} {1}", and, num[i % 100 % 10]); // три + десет и осем, четири + десет и седем
                    }



                }
                if (i <= 19) // Check if input is <=19
                {

                    if (i <= 12) // Check if input is <=12
                    {
                        if (i > 10) // Check if input is > 10 for 11 and 12 cases 
                        {
                            Console.WriteLine("{0}", num[i] + na + num[10]); //Print един + на + десет, два + на + десет

                        }
                        else
                        {

                            Console.WriteLine("{0}", num[i]); //Print едно, две, тре,...,девет, десет
                        }
                    }
                    else
                    {
                        Console.WriteLine("{0}", num[i % 10] + na + num[10]); //Print тре + на + десет, четири + на + десет, ....
                    }
                }
            }
            else
            {
                Console.WriteLine("Please ENTER integer input value in interval 0 - 999");
            }
        }
    }
}
