using System;

class SpiralArray
{
    static void Main()
    {
        Console.WriteLine("Enter a number");
        int number = int.Parse(Console.ReadLine());
        int[,] array = new int[number, number];
        int counter = 1;
        int rowIndex = 0;
        int colIndex = 0;
        int maxRowIndex = number - 1;
        int maxColIndex = number - 1;
        do
        {
            for (int i = colIndex; i <= maxColIndex; i++)
            {
                array[rowIndex, i] = counter;                               // right
                counter++;
            }
            rowIndex++;
            for (int i = rowIndex; i <= maxRowIndex; i++)
            {
                array[i, maxColIndex] = counter;                             // down
                counter++;
            }
            maxColIndex--;
            for (int i = maxColIndex; i >= colIndex; i--)
            {
                array[maxRowIndex, i] = counter;                             //left
                counter++;
            }
            maxRowIndex--;
            for (int i = maxRowIndex; i >= rowIndex; i--)
            {
                array[i, colIndex] = counter;                                //up
                counter++;
            }
            colIndex++;

        }
        while (counter <= number * number);

        for (int rows = 0; rows < array.GetLength(0); rows++)
        {
            for (int cols = 0; cols < array.GetLength(1); cols++)
            {
                Console.Write("{0,4}", array[rows, cols]);
            }
            Console.WriteLine();
        }

    }
}
