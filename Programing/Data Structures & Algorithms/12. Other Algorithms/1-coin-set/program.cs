using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

class Program
{
    /* 1 You are given a set of infinite number of coins (1, 2 and 5) and 
       end value - N. Write an algorithm that gives the number of coins 
       needed so that the sum of the coins equals N.
       Example:              				
       N = 33 => 6 coins x 5 + 1 coin x 2 + 1 coin x 1
    * */

    static void Main(string[] args)
    {
        // I assume the problem statement asks for the minimal number of coins.
        // the explicit solution is total / 5 + new []{0,1,1,2,2}[total%5]

        var test1 = GreedyChange(new[] { 5, 2, 1 }, 33);

        Console.WriteLine(test1);

        Debug.Assert(test1 == 6 + 1 + 1);

        for (int ii = 100; ii <= 100000; ii *= 10)
        {
            var result = RandomChange(new[] { 5, 2, 1 }, 33, ii);
            Console.WriteLine("Iterations: {0}, Result: {1}", ii, result);
            if (result == test1)
                break;
        }

        var test2 = GreedyChange(new[] { 5, 2, 1 }, 123);

        Console.WriteLine(test2);

        for (int ii = 1000; ii <= 100000; ii *= 10)
        {
            var result = RandomChange(new[] { 5, 2, 1 }, 123, ii);
            Console.WriteLine("Iterations: {0}, Result: {1}", ii, result);
            if (result == test2)
                break;
        }
    }

    // greedy algorithm 
    // coins are assumed to be sorted in descending order

    static int? GreedyChange(int[] coins, int targetTotal)
    {
        if (coins.Length == 0)
        {
            if (targetTotal == 0)
                return 0;
            return null;
        }

        var currentTotal = 0;
        var currentCount = 0;
        var maxCoin = coins[0];

        while (targetTotal - currentTotal >= maxCoin)
        {
            currentTotal += maxCoin;
            currentCount += 1;
        }

        if (currentTotal == targetTotal)
            return currentCount;

        // backtracking

        // try to drop some of the coins of the highest denomination

        var remaining = coins.Skip(1).ToArray();

        if (remaining.Length == 0)
            return null;

        for (int toDrop = 0; toDrop <= currentCount; ++toDrop)
        {
            var maybe = GreedyChange(remaining,
                targetTotal - currentTotal + toDrop * maxCoin);

            if (maybe == null)
                continue;

            return maybe.Value + currentCount - toDrop;
        }

        return null;

    }

    // randomized algorithm 

    static int? RandomChange(
        int[] coins, int targetTotal, int totalIterations)
    {
        var counts = new Dictionary<int, int>();

        foreach (var coin in coins)
        {
            counts[coin] = 0;
        }

        var random = new Random(0);
        var countSoFar = 0;
        var totalSoFar = 0;
        int? bestSoFar = null;

        while (totalIterations > 0)
        {
            totalIterations -= 1;
            if (targetTotal > totalSoFar)
            {
                int coin;
                do
                {
                    coin = coins[random.Next(0, coins.Length)];
                } while (coin > (targetTotal - totalSoFar));

                countSoFar += 1;
                totalSoFar += coin;
                counts[coin] += 1;
            }
            else
            {
                var toDrop = random.Next(1, countSoFar + 1);
                for (int ii = 0; ii < toDrop; ++ii)
                {
                    int coin;
                    do
                    {
                        coin = coins[random.Next(0, coins.Length)];
                    } while (counts[coin] == 0);

                    countSoFar -= 1;
                    totalSoFar -= coin;
                    counts[coin] -= 1;
                }
            }

            if (totalSoFar == targetTotal)
            {
                if (bestSoFar == null || bestSoFar > countSoFar)
                {
                    bestSoFar = countSoFar;
                }
            }

        }

        return bestSoFar;
    }
}