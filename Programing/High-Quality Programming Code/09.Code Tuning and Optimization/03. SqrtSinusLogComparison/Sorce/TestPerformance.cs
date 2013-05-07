namespace SqrtSinusLogComparison
{
    // Write a program to compare the performance of square root, natural logarithm, sinus for float, double and decimal values.

    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Text;
    using System.Threading;

    public class TestPerformance
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;


            SqrtMethods.CalculateSqrtDouble(2d, 10000d, 0.002d);

            SqrtMethods.CalculateSqrtDecimal(2m, 10000m, 0.002m);

            SqrtMethods.CalculateSqrtFloat(2f, 10000f, 0.002f);

            LogMethods.CalculateLogDouble(2d, 10000d, 0.002d);

            LogMethods.CalculateLogDecimal(2m, 10000m, 0.002m);

            LogMethods.CalculateLogFloat(2f, 10000f, 0.002f);

            SinusMethods.CalculateSinDouble(2d, 10000d, 0.002d);

            SinusMethods.CalculateSinDecimal(2m, 10000m, 0.002m);

            SinusMethods.CalculateSinFloat(2f, 10000f, 0.002f);
        }
    }
}