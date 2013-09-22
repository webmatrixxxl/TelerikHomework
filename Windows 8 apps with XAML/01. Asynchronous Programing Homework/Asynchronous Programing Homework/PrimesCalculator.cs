using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Asynchronous_Programing_Homework
{
    public static class PrimesCalculator
    {
        public static Task<string> GetPrimesInRangeAsync(int rangeFirst, int rangeLast, bool primeSwitch)
        {
            return Task.Run(
                () => GetPrimesInRange(rangeFirst, rangeLast, primeSwitch)
                    );
        }

        public static bool IsPrime(int number)
        {
            double boundary = Math.Floor(Math.Sqrt(number));

            if (number <= 1)
            {
                return false;
            }

            if (number == 2)
            {
                return true;
            }

            for (int i = 2; i <= boundary; ++i)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public async static Task<string> GetPrimesInRange(int rangeFirst, int rangeLast, bool primeSwitch)
        {
            List<int> primes = new List<int>();

            for (int number = rangeFirst; number < rangeLast; number++)
            {
                if (IsPrime(number))
                {
                    primes.Add(number);
                }
            }

            List<int> primeList = new List<int>();
            List<int> unprimeList = new List<int>();

            for (int y = 0; y < primes.Count; y++)
            {
                var primo = primes[y].ToString();
                var firstNumOfPrime = primo[primo.Length - 1].ToString();

                for (int i = y + 1; i < primes.Count; i++)
                {
                    var lastNumOfNextPrime = primes[i].ToString()[0].ToString();

                    if (firstNumOfPrime == lastNumOfNextPrime)
                    {
                        var newNum = int.Parse(primes[y] + "" + primes[i]);

                        if (PrimesCalculator.IsPrime(newNum))
                        {
                            primeList.Add(newNum);
                        }
                        else
                        {
                            unprimeList.Add(newNum);
                        }
                    }
                }
            }

            if (primeSwitch)
            {
                var result = await primeList.JoinAsStringAsync<int>(", ");
                return result;
            }
            else
            {
                var result = await unprimeList.JoinAsStringAsync<int>(", ");
                return result;
            }
        }
    }
}
