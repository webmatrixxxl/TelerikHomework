using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class AcademyPopcornMain
    {
        const int WorldRows = 23;
        const int WorldCols = 40;
        const int RacketLength = 6;
       
        static void Initialize(Engine engine)
        {
            int startRow = 3;
            int startCol = 2;
            int endCol = WorldCols - 2;
            Random rnd = new Random();

            for (int i = startCol; i < endCol; i++)
            {
               
                

                if (rnd.Next(startCol, WorldCols*2)> endCol)
                {
                    Block currBlock = new Block(new MatrixCoords(startRow, i));
                    engine.AddObject(currBlock);
                }
                else if (rnd.Next(startCol, WorldCols * 3) > endCol)
                {
                    ExplodingBlock boomBlock = new ExplodingBlock(new MatrixCoords(startRow, i));

                    engine.AddObject(boomBlock);
                }
                else if (rnd.Next(startCol, WorldCols * 4) > endCol)
                {
                    GiftBlock giftBlock = new GiftBlock(new MatrixCoords(startRow, i));

                    engine.AddObject(giftBlock);
                }
                else
                {
                    UnpassableBlock unpBlock = new UnpassableBlock(new MatrixCoords(startRow, i));
                    engine.AddObject(unpBlock);
                }
                
            }

            MeteoriteBall theBall = new MeteoriteBall(new MatrixCoords(WorldRows / 2, 0),
                new MatrixCoords(-1, 1));

            engine.AddObject(theBall);

            Racket theRacket = new Racket(new MatrixCoords(WorldRows - 1, WorldCols / 2), RacketLength);

            engine.AddObject(theRacket);
            Racket newtheRacket = new Racket(new MatrixCoords(WorldRows - 1, WorldCols / 2), RacketLength + 1);
            engine.AddObject(newtheRacket);
            // Add side wallsя
            for (int row = 0; row < WorldRows; row++)
            {
                IndestructibleBlock leftWallBlock = new IndestructibleBlock(new MatrixCoords(row, 0));
                engine.AddObject(leftWallBlock);
                IndestructibleBlock rightWallBlock = new IndestructibleBlock(new MatrixCoords(row, WorldCols - 1));
                engine.AddObject(rightWallBlock);
            }
            for (int col = 0; col < WorldCols; col++)
            {
                IndestructibleBlock roof = new IndestructibleBlock(new MatrixCoords(0, col));
                engine.AddObject(roof);
            }

        }

        static void Main(string[] args)
        {
            IRenderer renderer = new ConsoleRenderer(WorldRows, WorldCols);
            IUserInterface keyboard = new KeyboardInterface();

            Engine gameEngine = new Engine(renderer, keyboard, 200);

            keyboard.OnLeftPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketLeft();
            };

            keyboard.OnRightPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketRight();
            };

            Initialize(gameEngine);

            //

            gameEngine.Run();
        }
    }
}
