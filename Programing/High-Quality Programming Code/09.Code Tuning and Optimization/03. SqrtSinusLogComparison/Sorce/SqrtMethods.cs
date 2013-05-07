using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqrtSinusLogComparison
{
    class SqrtMethods
    {
        public static void CalculateSqrtFloat(float startValue, float endValue, float step)
        {
            for (float i = startValue; i <= endValue; i = i + step)
            {
                Math.Sqrt(i);
            }
        }

        public static void CalculateSqrtDecimal(decimal startValue, decimal endValue, decimal step)
        {
            for (decimal i = startValue; i <= endValue; i = i + step)
            {
                Math.Sqrt((double)i);
            }
        }

        public static void CalculateSqrtDouble(double startValue, double endValue, double step)
        {
            for (double i = startValue; i <= endValue; i = i + step)
            {
                Math.Sqrt(i);
            }
        }
    }
}