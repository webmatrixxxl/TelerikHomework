using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _14.exchangeGivenBits
{
    class exchangeBits
    {
        static void Main(string[] args)
        {
            uint givenInt = 70345;   //random 32 bit number
            Console.WriteLine("given integer is: {0}", Convert.ToString(givenInt, 2).PadLeft(32, '0'));  //display it as binary
            byte positionCount = 3;     //number of adjacent positions that will be subject to modification
            byte firstGroupStart = 4;   //the first group of bits is defined by starting position (k) and the positionCount number
            byte secondGroupStart = 10;   //the second group of bits is defined by starting position (q) and the positionCount number
            uint mask = (uint)(1 * (1 - Math.Pow(2, positionCount)) / (1 - 2));  //this is a modified sum of geometric progression

            Console.WriteLine("The mask is {0}", Convert.ToString(mask, 2));    //example: 3 desired positions will give us number 7 (or 111)

            uint firstBits = (mask << firstGroupStart) & givenInt;         //gets the bits of the first group
            firstBits = firstBits << secondGroupStart;                    //moves them q positions to the left
            uint secondBits = (mask << secondGroupStart) & givenInt;       //analogically for the second group  
            secondBits = secondBits >> firstGroupStart;

            givenInt = (~(mask << firstGroupStart)) & givenInt;           //bits of the first group will become 0
            uint modifiedResult = givenInt | secondBits;               //extracted bits from second group replace bits in first group

            givenInt = (~(mask << secondGroupStart)) & givenInt;          //analogically for the second group
            modifiedResult = givenInt | firstBits;

            Console.WriteLine("Result: {0}", Convert.ToString(modifiedResult, 2).PadLeft(32, '0'));     //final result
            Console.WriteLine(modifiedResult);


        }
    }
}