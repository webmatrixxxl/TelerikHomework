using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TeamGame
{
    public class Score : GameObject
    {

        public Score(MatrixCoords topLeft, char[,] body)
            : base(topLeft, body)
        {
        }
        
        public override void Update()
        {
            int scoreInt = SnakeHead.Score;
            Console.SetCursorPosition(10, 2);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("{0}", scoreInt);
            Console.ForegroundColor = ConsoleColor.Green;
            Thread.Sleep(100 - scoreInt);
        }
    }
}
