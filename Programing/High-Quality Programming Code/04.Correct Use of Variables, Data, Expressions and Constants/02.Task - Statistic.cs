namespace FigureRotator
{
    using System;

    public class Statistic
    {
        public void PrintStatistics(double[] arr, int count)
        {
            double arrayMax = 0;

            for (int i = 0; i < count; i++)
            {
                if (arr[i] > arrayMax)
                {
                    arrayMax = arr[i];
                }
            }

            PrintMax(arrayMax);
            double arrayMin;

            for (int i = 0; i < count; i++)
            {
                if (arr[i] < arrayMin)
                {
                    arrayMin = arr[i];
                }
            }

            PrintMin(arrayMin);
            double arraySum = 0;

            for (int i = 0; i < count; i++)
            {
                arraySum += arr[i];
            }

            PrintAvg(arraySum / count);
        }
    }
}