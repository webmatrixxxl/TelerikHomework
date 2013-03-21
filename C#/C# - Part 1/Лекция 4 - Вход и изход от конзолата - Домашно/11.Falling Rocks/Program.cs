using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _11.Falling_Rocks
{
    class Program
    {

        static int playerPadSize = 1;
        static int playerPositionX = Console.WindowWidth / 2 - playerPadSize % 2;
        static int playerPositionY = Console.WindowHeight-1;
        static int RrocksIntensiti = 20;
        static char[] rocks = { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';' };
        static Random randomGenerator = new Random();

        static void RemoveScrollBars()
        {
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth;
            Console.ForegroundColor = ConsoleColor.Green;
        }
        static void DrowPlayer()
        {
            for (int i = 0; i < playerPadSize; i++)
            {

                PrintAtPosition(playerPositionX + i, playerPositionY, '0');
            }

        }
        static void DrowRocks()
        {
            for (int i = 0; i < RrocksIntensiti; i++)
            {

                int a = randomGenerator.Next(0, 11);
                PrintAtPosition(1, 1, rocks[a]);
            }

           
        }
        static void PrintAtPosition(int x, int y, char symbol)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(symbol);
        }
        private static void SetInitialPositions()
        {
           
        }
        private static void MovePlayerRight()
        {
           //TODO: move player Right
            if (playerPositionX<Console.WindowWidth-3)
            {
                playerPositionX++;
            }
            
        }

        private static void MovePlayerLeft()
        {
            //TODO: move player Left
            if (playerPositionX > 0)
            {
                playerPositionX--; 
            }
            
            
        }


        static void Main(string[] args)
        {
            RemoveScrollBars();
            SetInitialPositions();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey();
                    if (keyInfo.Key == ConsoleKey.LeftArrow)
                    {
                        MovePlayerLeft();
                    }
                    if (keyInfo.Key == ConsoleKey.RightArrow)
                    {
                        MovePlayerRight();
                    }
                }
                

                // Falling ROCKS
                // Redraw all
                Console.Clear();
                DrowPlayer();
                DrowRocks();
                // - print result

                Thread.Sleep(150);
            }
        }

       
        
    }
}
