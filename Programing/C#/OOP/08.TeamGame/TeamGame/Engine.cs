using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TeamGame
{
    public class Engine
    {
        IRenderer renderer;
        IUserInterface userInterface;
        public List<GameObject> allObjects;
        public List<MovingObject> movingObjects;
        public List<GameObject> staticObjects;
        public SnakeHead snakeHead = new SnakeHead(new MatrixCoords(7, 4),
            new MatrixCoords(0, 1), 20);


        private int sleepTimeout;

        public Engine(IRenderer renderer, IUserInterface userInterface, int sleepTimeout = 10)
        {
            this.renderer = renderer;
            this.userInterface = userInterface;
            this.allObjects = new List<GameObject>();
            this.movingObjects = new List<MovingObject>();
            this.staticObjects = new List<GameObject>();
            this.sleepTimeout = sleepTimeout;

            //02.
        }

        private void AddStaticObject(GameObject obj)
        {
            this.staticObjects.Add(obj);
            this.allObjects.Add(obj);
        }

        private void AddMovingObject(MovingObject obj)
        {
            this.movingObjects.Add(obj);
            this.allObjects.Add(obj);
        }

        public virtual void AddObject(GameObject obj)
        {
            if (obj is MovingObject)
            {
                this.AddMovingObject(obj as MovingObject);
            }
            else
            {
                if (obj is SnakeHead)
                {
                    AddSnake(obj);

                }
                else
                {
                    this.AddStaticObject(obj);
                }
            }
        }

        /// <summary>
        /// 03.Since the player uses one racket only, we should remove the
        /// existing racket before introducing another one.
        /// </summary>
        private void RemoveRacket()
        {
            this.movingObjects.RemoveAll(obj => obj is SnakeHead);
            this.allObjects.RemoveAll(obj => obj is SnakeHead);
            this.staticObjects.RemoveAll(obj => obj is SnakeHead);
        }

        private void AddSnake(GameObject obj)
        {
            RemoveRacket();
            this.snakeHead = obj as SnakeHead;
            this.AddObject(obj);
        }

        public virtual void MovePlayerRacketLeft()
        {
            this.snakeHead.MoveLeft();
        }

        public virtual void MovePlayerRacketRight()
        {

            this.snakeHead.MoveRight();
        }

        public virtual void MovePlayerRacketUp()
        {
            this.snakeHead.MoveUp();
        }

        public virtual void MovePlayerRacketDown()
        {
            this.snakeHead.MoveDown();
        }

        // Game Over method
        public static void Over()
        {
            Console.Clear();
            Console.SetCursorPosition((int)(Console.WindowWidth / 2.5), (int)(Console.WindowHeight / 2.5));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("G A M E   O V E R!");
            SystemSounds.Hand.Play();
            Console.WriteLine();
            Console.SetCursorPosition((int)(Console.WindowWidth / 2.6), (Console.WindowHeight / 2));
            Console.WriteLine("Your Score: {0} points", SnakeHead.Score);
            Thread.Sleep(1000);
            Console.ReadKey();
        }

        // Start Game
        public static void Start(int seconds)
        {
            Console.SetCursorPosition((int)(Console.WindowWidth / 2.5), (int)(Console.WindowHeight / 2.5));
            Console.WriteLine("G E T  R E A D Y...");
            Console.WriteLine();
            Console.SetCursorPosition((int)(Console.WindowWidth / 2.9), (Console.WindowHeight / 2));
            Console.WriteLine("F O R  P Y T H O N  K A A!");
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(2000);

            while (seconds > 0)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(Console.WindowWidth / 3, Console.WindowHeight / 2);
                Console.WriteLine("Game will start in {0} seconds.", seconds);
                SystemSounds.Asterisk.Play();

                seconds--;
                Thread.Sleep(1000);
            }
            SystemSounds.Exclamation.Play();
        }

        public virtual void Run()
        {
            // Start Game
            Engine.Start(3);

            while (true)
            {
                this.renderer.RenderAll();

                System.Threading.Thread.Sleep(sleepTimeout);

                this.userInterface.ProcessInput();

                this.renderer.ClearQueue();

                foreach (var obj in this.allObjects)
                {
                    obj.Update();
                    this.renderer.EnqueueForRendering(obj);
                }

                CollisionDispatcher.HandleCollisions(this.movingObjects, this.staticObjects);

                List<GameObject> producedObjects = new List<GameObject>();

                foreach (var obj in this.allObjects)
                {
                    producedObjects.AddRange(obj.ProduceObjects());
                }

                this.allObjects.RemoveAll(obj => obj.IsDestroyed);
                this.movingObjects.RemoveAll(obj => obj.IsDestroyed);
                this.staticObjects.RemoveAll(obj => obj.IsDestroyed);

                foreach (var obj in producedObjects)
                {
                    this.AddObject(obj);
                }
            }
        }

    }
}
