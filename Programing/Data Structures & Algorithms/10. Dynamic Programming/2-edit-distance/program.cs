using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

class Program
{
    const decimal COST_DELETE = 0.9m;
    const decimal COST_INSERT = 0.8m;
    const decimal COST_REPLACE = 1.0m;

    /* 2 Write a program to calculate the "Minimum Edit Distance" (MED) 
    between two words. MED(x, y) is the minimal sum of costs of edit 
    operations used to transform x to y. Sample costs are given below:
    cost (replace a letter) = 1
    cost (delete a letter) = 0.9
    cost (insert a letter) = 0.8
    Example: 
        x = "developer", y = "enveloped"  cost = 2.7 
        delete 'd':  "developer"  "eveloper", cost = 0.9
        insert 'n':  "eveloper"  "enveloper", cost = 0.8
        replace 'r'  'd':  "enveloper"  "enveloped", cost = 1
    * */

    static void Main(string[] args)
    {
        decimal test1 = EditDistanceRecursive("developer", "enveloped", 0, 0);
        Console.WriteLine(test1);
        Debug.Assert(test1 == 2.7m);

        // stalls!
        // decimal test2 = EditDistanceRecursive("Thou shalt not","You should not);
        // Console.WriteLine(test2);
        // Debug.Assert(test2 == COST_DELETE + COST_INSERT + 3*COST_REPLACE);

        decimal test3 = EditDistanceDynamic("developer", "enveloped");
        Console.WriteLine(test3);
        Debug.Assert(test3 == 2.7m);

        decimal test4 = EditDistanceDynamic("Thou shalt not", "You should not");
        Console.WriteLine(test4);
        Debug.Assert(test4 == COST_DELETE + COST_INSERT + 3 * COST_REPLACE);
    }

    // recursive implementation of Levenshtein's Edit Distance algorithm
    // O(e^(m+n)/(m*n))

    static decimal EditDistanceRecursive(string pattern, string input, int pp = 0, int pi = 0)
    {
        if (pp == pattern.Length && pi == pattern.Length)
            return 0;

        decimal minCostPi = decimal.MaxValue;
        decimal minCost2 = decimal.MaxValue;
        decimal minCostPp = decimal.MaxValue;

        if (pi < input.Length)
            minCostPi = COST_DELETE + EditDistanceRecursive(pattern, input, pp, pi + 1);

        if (pi < input.Length && pp < input.Length)
            minCost2 = (pattern[pp] == input[pi] ? 0 : COST_REPLACE) +
                            EditDistanceRecursive(pattern, input, pp + 1, pi + 1);

        if (pp < pattern.Length)
            minCostPp = COST_INSERT + EditDistanceRecursive(pattern, input, pp + 1, pi);

        return Math.Min(minCostPi, Math.Min(minCost2, minCostPp));
    }


    // Dymamic programming re-implementation, uses only 2*n table instead of m*n
    // time: O(m*n)

    static decimal EditDistanceDynamic(string pattern, string input)
    {
        // n + 1 positions for each pointer

        decimal[,] table = new decimal[2, input.Length + 1];

        // going right means skpping from input / deleting from string

        for (int pi = 1; pi <= input.Length; ++pi)
        {
            table[0, pi] = pi * COST_DELETE;
        }

        // going down means skipping from pattern / inserting into string


        // fill the table

        int pp;
        for (pp = 1; pp <= pattern.Length; ++pp)
        {   
            int thisRow = pp % 2;
            int prevRow = 1 - thisRow;
            
            table[thisRow, 0] = pp * COST_INSERT;

            for (int pi = 1; pi <= input.Length; ++pi)
            {
                decimal cost = (input[pi - 1] == pattern[pp - 1]) ? 0 : COST_REPLACE;

                decimal minCostPi = table[thisRow, pi - 1] + COST_DELETE;
                decimal minCost2 = table[prevRow, pi - 1] + cost;
                decimal minCostPp = table[prevRow, pi] + COST_INSERT;

                table[thisRow, pi] = Math.Min(Math.Min(minCostPp, minCostPi), minCost2);
            }

        }

        return table[1 - (pp % 2), input.Length];
    }
}
