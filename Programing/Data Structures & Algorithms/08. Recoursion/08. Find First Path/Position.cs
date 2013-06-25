using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Find_First_Path
{
    public class Position
    {
        public int positionX { get; set; }
        public int positionY { get; set; }

        public Position(int positionX, int positionY)
        {
            this.positionX = positionX;
            this.positionY = positionY;
        }
    }
}
