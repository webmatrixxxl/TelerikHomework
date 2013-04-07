using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  Task5 Implement a TrailObject class. It should inherit the GameObject class and should have a constructor 
//  which takes an additional "lifetime" integer. The TrailObject should disappear after a "lifetime" amount of turns.
namespace AcademyPopcorn
{
    class TrailObject : GameObject
    {
        public int lifeTime { get; set; }

        public TrailObject(MatrixCoords topLeft, char[,] body, int lifeTime)
            : base(topLeft, body)
        {
            this.lifeTime = lifeTime;
        }
        public override void Update()
        {
            lifeTime--;
            if (lifeTime <= 0)
            {
                this.IsDestroyed = true;
            }
        }
    }
}
