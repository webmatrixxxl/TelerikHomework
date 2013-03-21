using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.AbstractClassShape
{
    abstract class Shape
    {
        public int width { get; set; }
        public int height { get; set; }

        public Shape(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        abstract public int CalculateSurface();
    }
}
