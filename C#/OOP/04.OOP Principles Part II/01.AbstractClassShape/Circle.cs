using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.AbstractClassShape
{
    class Circle : Shape
    {
        public Circle(int diametar)
            : base(diametar, diametar)
        {
        }
        public override int CalculateSurface()
        {
            return height * width;
        }
    }
}
