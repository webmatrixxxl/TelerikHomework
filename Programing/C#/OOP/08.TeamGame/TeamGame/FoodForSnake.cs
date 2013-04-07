using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;

namespace TeamGame
{
    public class FoodForSnake : GameObject
    {
        public static FoodForSnake food; 
        
        public new const string CollisionGroupString = "foodforsnake";

        public FoodForSnake(MatrixCoords topLeft)
            : base(topLeft, new char[,] { { '@' } })
        {
            //Console.ForegroundColor = ConsoleColor.Yellow;
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "SnakeHead";
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
            SystemSounds.Beep.Play();
        }

        public override string GetCollisionGroupString()
        {
            return FoodForSnake.CollisionGroupString;
        }

        public override void Update()
        {
            // throw new NotImplementedException();
        }
        
        public override IEnumerable<GameObject> ProduceObjects()
        {
            
            Random rand = new Random();
            int pos1 = rand.Next(6, 22);
            
            int pos2 = rand.Next(3, 47);
            List<GameObject> produceObjects = new List<GameObject>();
            if (this.IsDestroyed)
            {
                food = new FoodForSnake(new MatrixCoords(pos1, pos2));
                produceObjects.Add(new FoodForSnake(new MatrixCoords(pos1, pos2)));
            }
            return produceObjects;
        }
    }
}
