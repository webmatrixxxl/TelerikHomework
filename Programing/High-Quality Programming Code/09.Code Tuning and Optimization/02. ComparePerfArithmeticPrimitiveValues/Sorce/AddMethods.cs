using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComparePerfArithmeticPrimitiveValues
{
    public class AddMethods
    {
        public static void AddInt(int startValue, int endValue)
        {
            for (int i = startValue; i < endValue; )
            {
                i++;
            }
        }
        public static void AddLong(long startValue, long endValue)
        {
            for (long i = startValue; i < endValue; )
            {
                i++;
            }
        }
        public static void AddFloat(float startValue, float endValue)
        {
            for (float i = startValue; i < endValue; )
            {
                i++;
            }
        }
        public static void AddDouble(double startValue, double endValue)
        {
            for (double i = startValue; i < endValue; )
            {
                i++;
            }
        }
        public static void AddDecimal(decimal startValue, decimal endValue)
        {
            for (decimal i = startValue; i < endValue; )
            {
                i++;
            }
        }
    }
}
