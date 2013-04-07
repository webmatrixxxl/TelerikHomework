using System;

class CalculateTheNCatalanNumber
{
    static void Main()
    {
        double n = 5;
        double nFact = n;
        double nPlusOne = n + 1;
        double nPoTwo = n * 2;
        double nResult = 1;
        double nPlusOneResult = 1;
        double nPoTwoResult = 1;

        for (int i = 1; i <= nFact; i++)
        {
            nResult *= i;
        }
        for (int i = 1; i <= nPlusOne; i++)
        {
            nPlusOneResult *= i;

        }
        for (int i = 1; i <= nPoTwo; i++)
        {
            nPoTwoResult *= i;

        }

        Console.WriteLine(nPlusOneResult);
        Console.WriteLine(nPoTwoResult);
        Console.WriteLine(nResult);

        double resul = nPoTwoResult / (nPlusOneResult * nResult);
        Console.WriteLine(resul);
    }
}
