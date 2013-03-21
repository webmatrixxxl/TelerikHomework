using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  Implement an ExplodingBlock. It should destroy all blocks around it when it is destroyed.
//  You must NOT edit any existing .cs file. Hint: what does an explosion "produce"?


namespace AcademyPopcorn
{
    public class ExplodingBlock : Block
    {
        public ExplodingBlock(MatrixCoords topLeft)
            : base(topLeft)
        {
            this.body = new char[,] { { 'B' } };
        }
        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
        }
        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<GameObject> produceObjects = new List<GameObject>();
            if (this.IsDestroyed)
            {
                produceObjects.Add(new Explosion(this.topLeft, new char[,] { { '+' } }, new MatrixCoords(-1, 0)));
                produceObjects.Add(new Explosion(this.topLeft, new char[,] { { '+' } }, new MatrixCoords(1, 0)));
                produceObjects.Add(new Explosion(this.topLeft, new char[,] { { '+' } }, new MatrixCoords(0, 1)));
                produceObjects.Add(new Explosion(this.topLeft, new char[,] { { '+' } }, new MatrixCoords(0, -1)));
            }
            return produceObjects;
        }
    }
}
