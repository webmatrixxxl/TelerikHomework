using System;

class TrailingZeros
{
    static void Main()
    {
        Console.Write("N = ");
        int number = int.Parse(Console.ReadLine());
        int divider = 5;
        int trailingZeros = 0;
        while (divider <= number)
        {
            trailingZeros += number / divider;
            divider = divider * 5;
        }
        Console.WriteLine(trailingZeros);

    }
}