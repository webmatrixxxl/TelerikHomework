using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamGame
{
    class AcademyMain
    {
        //Declaring Our World
        const int WorldRows = 25;
        const int WorldCols = 50;
        
        // New Size of the Console Window
        const int WindowWidth = 65;
        const int WindowHeight = 35;

        static void Initialize(Engine engine)
        {
            int startRow = 5;
            int startCol = 2;
            int endCol = WorldCols - 2;
            int endRow = WorldRows - 2;
            //int scoreInt = SnakeHead.Score;
            //char[] scoreStr = string.Format("Score: {0,F3}", scoreInt).ToCharArray(); 

            Score scorePoints = new Score(new MatrixCoords(2, 2),
                new char[,] { { 'S', 'C', 'O', 'R', 'E', ':'} });
            engine.AddObject(scorePoints);

            // Setting the new size of the window
            // You can adjust it by your choise
            Console.WindowWidth = WindowWidth;
            Console.WindowHeight = WindowHeight;



            //NorthWall
            for (int i = startCol; i < endCol; i++)
            {
                IndestructableWall currBlock = new IndestructableWall(new MatrixCoords(startRow, i));
                SnakeHead.DoNotEatingList.Add(currBlock);
                engine.AddObject(currBlock);
            }

            //RightWall
            for (int i = startRow; i <= endRow; i++)
            {
                IndestructableWall currBlock = new IndestructableWall(new MatrixCoords(i, endCol));
                SnakeHead.DoNotEatingList.Add(currBlock);
                engine.AddObject(currBlock);
            }

            //SouthWall
            for (int i = startCol; i < endCol; i++)
            {
                IndestructableWall currBlock = new IndestructableWall(new MatrixCoords(endRow, i));
                SnakeHead.DoNotEatingList.Add(currBlock);
                engine.AddObject(currBlock);
            }

            //LeftWall
            for (int i = startRow; i < endRow; i++)
            {
                IndestructableWall currBlock = new IndestructableWall(new MatrixCoords(i, startCol));
                SnakeHead.DoNotEatingList.Add(currBlock);
                engine.AddObject(currBlock);
            }

            //SnakeHead snakeHead = new SnakeHead(new MatrixCoords(12, 12), new MatrixCoords(0,0));
            
            engine.AddObject(engine.snakeHead);

            // FoodForSnake
            Random rand = new Random();
            int pos1 = rand.Next(6, 22);//6-22
            int pos2 = rand.Next(3, 47);//3-47
            FoodForSnake.food = new FoodForSnake(new MatrixCoords(pos1, pos2));
            FoodForSnake food = new FoodForSnake(new MatrixCoords(pos1, pos2));
            
            engine.AddObject(food);
            
        }

        static void Main(string[] args)
        {
            IRenderer renderer = new ConsoleRenderer(WorldRows, WorldCols);
            IUserInterface keyboard = new KeyboardInterface();

            Engine gameEngine = new Engine(renderer, keyboard);

            keyboard.OnLeftPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketLeft();
            };

            keyboard.OnRightPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketRight();
            };

            keyboard.OnUpPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketUp();
            };

            keyboard.OnDownPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketDown();
            };

            Initialize(gameEngine);

            gameEngine.Run();
        }
    }
}
