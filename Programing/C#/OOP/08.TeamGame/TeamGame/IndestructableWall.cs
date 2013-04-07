using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeamGame
{
    public class IndestructableWall : GameObject
    {
        //Fields
        public new const string CollisionGroupString = "IndestructableWall";
        public char[,] IndestructableBody = {{'#'}};

        public IndestructableWall(MatrixCoords topLeft)
            : base(topLeft, new char[,] { { '#' } })
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }

        public override void Update()
        {
          
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "nothing";
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
        }

        public override string GetCollisionGroupString()
        {
            return IndestructableWall.CollisionGroupString;
        }


    }
}
