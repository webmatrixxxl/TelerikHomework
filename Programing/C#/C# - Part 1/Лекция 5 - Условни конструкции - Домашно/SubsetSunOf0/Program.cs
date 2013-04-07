using System;
using System.Globalization;
using System.Threading;

class ZeroSumSubsetCheck
{
    static int a1;
    static int b2;
    static int c3;
    static int d4;
    static int e5;

    static void inputConsole()
    {
        Console.Write("Write first integer ");
        a1 = int.Parse(Console.ReadLine());
        Console.Write("Write second integer ");
        b2 = int.Parse(Console.ReadLine());
        Console.Write("Write third integer ");
        c3 = int.Parse(Console.ReadLine());
        Console.Write("Write fort integer ");
        d4 = int.Parse(Console.ReadLine());
        Console.Write("Write fift integer ");
        e5 = int.Parse(Console.ReadLine());

    }

    static void ZeroSum2(int a, int b)
    {
        if ((a + b) == 0)
        {
            Console.WriteLine("One zero sum subnet is ({0}) + ({1}) = 0", a, b);
        }
    }

    static void ZeroSum3(int a, int b, int c)
    {
        if ((a + b + c) == 0)
        {
            Console.WriteLine("One zero sum subnet is ({0}) + ({1}) + ({2})= 0", a, b, c);
        }
    }

    static void ZeroSum4(int a, int b, int c, int d)
    {
        if ((a + b + c + d) == 0)
        {
            Console.WriteLine("One zero sum subnet is ({0}) + ({1}) + ({2}) + ({3}) = 0", a, b, c, d);
        }
    }

    static void Main()
    {
        inputConsole();
        if (a1 + b2 + c3 + d4 + e5 > 0)
        {
            Console.WriteLine("There is no zerro sum subset - all members are postiv numbers!");
        }
        else
        {

            if ((a1 == 0) || (b2 == 0) || (c3 == 0) || (d4 == 0) || (e5 == 0))
            {
                Console.WriteLine("There is zero sum subset - one of the numbers is zero");
            }
            if ((a1 + b2 + c3 + d4 + e5) == 0)
            {
                Console.WriteLine("One zero sum subnet is ({0}) + ({1}) + ({2}) + ({3}) + ({4}) = 0", a1, b2, c3, d4, e5);
            }
            ZeroSum2(a1, b2);
            ZeroSum2(a1, c3);
            ZeroSum2(a1, d4);
            ZeroSum2(a1, e5);
            ZeroSum2(b2, c3);
            ZeroSum2(b2, d4);
            ZeroSum2(b2, e5);
            ZeroSum2(c3, d4);
            ZeroSum2(c3, e5);
            ZeroSum2(d4, e5);
            ZeroSum3(a1, b2, c3);
            ZeroSum3(a1, b2, d4);
            ZeroSum3(a1, b2, e5);
            ZeroSum3(a1, c3, d4);
            ZeroSum3(a1, c3, e5);
            ZeroSum3(a1, d4, e5);
            ZeroSum3(b2, c3, d4);
            ZeroSum3(b2, c3, e5);
            ZeroSum3(b2, d4, e5);
            ZeroSum3(c3, d4, e5);
            ZeroSum4(a1, b2, c3, d4);
            ZeroSum4(a1, b2, c3, e5);
            ZeroSum4(a1, b2, d4, e5);
            ZeroSum4(a1, c3, d4, e5);
            ZeroSum4(b2, c3, d4, e5);

        }
    }
}
