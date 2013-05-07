using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqrtSinusLogComparison
{
    class SinusMethods
    {
        public static void CalculateSinFloat(float startValue, float endValue, float step)
        {
            for (float i = startValue; i <= endValue; i = i + step)
            {
                Math.Sin(i);
            }
        }

        public static void CalculateSinDecimal(decimal startValue, decimal endValue, decimal step)
        {
            for (decimal i = startValue; i <= endValue; i = i + step)
            {
                Math.Sin((double)i);
            }
        }

        public static void CalculateSinDouble(double startValue, double endValue, double step)
        {
            for (double i = startValue; i <= endValue; i = i + step)
            {
                Math.Sin(i);
            }
        }
    }
}