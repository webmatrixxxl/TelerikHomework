using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionOfIEnumerable
{
    static class ExtensionOfIEnumerable
    {
        public static T Sum<T>(this IEnumerable<T> input) 
        {
            dynamic sum = 0;

            foreach (var item in input)
            {
                sum += item;
            }

            return sum;
        }

        public static T Product<T>(this IEnumerable<T> input) 
        {
            dynamic product = 1;

            foreach (var item in input)
            {
                product *= item;
            }

            return product;
        }

        public static T Min<T>(this IEnumerable<T> input) 
        {
            dynamic min = int.MaxValue;

            foreach (var item in input)
            {
                if (item < min)
                {
                    min = item;
                }
            }

            return min;
        }

        public static T Max<T>(this IEnumerable<T> input) 
        {
            dynamic max = int.MinValue;

            foreach (var item in input)
            {
                if (item > max)
                {
                    max = item;
                }
            }

            return max;
        }

        public static decimal Average<T>(this IEnumerable<T> input) 
        {
            dynamic sum = 0;
            decimal counter = 0;

            foreach (var item in input)
            {
                sum += item;
                counter++;
            }

            return sum / counter;
        }
    }
}
