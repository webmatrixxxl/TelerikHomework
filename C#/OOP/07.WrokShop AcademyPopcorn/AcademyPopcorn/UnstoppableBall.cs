using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  Implement an UnstoppableBall and an UnpassableBlock. The UnstopableBall only bounces off
//  UnpassableBlocks and will destroy any other block it passes through. The UnpassableBlock
//  should be indestructible. Hint: Take a look at the RespondToCollision method, the GetCollisionGroupString
//  method and the CollisionData class.


namespace AcademyPopcorn
{
    class UnstoppableBall : Ball
    {

        public const char Symbol = 'Q';
        public new const string CollisionGroupString = "unstoppableBall";
        public UnstoppableBall(MatrixCoords topLeft, MatrixCoords speed)
            : base(topLeft, speed)
        {
            this.body[0, 0] = Symbol;
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "racket" || otherCollisionGroupString == "block"
                || otherCollisionGroupString == "unpassableBlock" || otherCollisionGroupString == "indestructibleBlock";
        }

        public override string GetCollisionGroupString()
        {
            return UnstoppableBall.CollisionGroupString;
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            for (int i = 0; i < collisionData.hitObjectsCollisionGroupStrings.Count; i++)
            {
                if (collisionData.hitObjectsCollisionGroupStrings[i] == "unpassableBlock" || collisionData.hitObjectsCollisionGroupStrings[i] == "racket"
                    || collisionData.hitObjectsCollisionGroupStrings[i] == "indestructibleBlock")
                {
                    if (collisionData.CollisionForceDirection.Row * this.Speed.Row < 0)
                    {
                        this.Speed.Row *= -1;
                    }
                    if (collisionData.CollisionForceDirection.Col * this.Speed.Col < 0)
                    {
                        this.Speed.Col *= -1;
                    }
                }
            }
        }
    }
}
