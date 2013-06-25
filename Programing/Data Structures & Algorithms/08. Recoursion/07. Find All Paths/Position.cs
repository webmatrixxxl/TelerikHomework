using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Find_All_Paths
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
