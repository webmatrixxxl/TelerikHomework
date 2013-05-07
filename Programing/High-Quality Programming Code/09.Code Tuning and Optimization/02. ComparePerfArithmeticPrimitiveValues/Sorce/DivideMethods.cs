using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComparePerfArithmeticPrimitiveValues
{
    public class DivideMethods
    {
        public static void DivideInt(int startValue, int endValue, int step)
        {
            for (int i = startValue; i >= endValue; )
            {
                i = i / step;
            }
        }
        public static void DivideLong(long startValue, long endValue, long step)
        {
            for (long i = startValue; i >= endValue; )
            {
                i = i / step;
            }
        }
        public static void DivideFloat(float startValue, float endValue, float step)
        {
            for (float i = startValue; i >= endValue; )
            {
                i = i / step;
            }
        }
        public static void DivideDouble(double startValue, double endValue, double step)
        {
            for (double i = startValue; i >= endValue; )
            {
                i = i / step;
            }
        }
        public static void DivideDecimal(decimal startValue, decimal endValue, decimal step)
        {
            for (decimal i = startValue; i >= endValue; )
            {
                i = i / step;
            }
        }
    }
}