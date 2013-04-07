using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeamGame
{
    public class TrailObject : GameObject
    {

        public int lifeTime { get; set; }

        public TrailObject(MatrixCoords topLeft, char[,] body, int lifeTime)
            : base(topLeft, new char[,] { { '+' } })
        {
            this.lifeTime = lifeTime;
        }

            public override void Update()
            {
                if (lifeTime > 0)
                {
                    lifeTime--;
                }
                else
                {

                    this.IsDestroyed = true;
                }
            }
    
    }       
}
