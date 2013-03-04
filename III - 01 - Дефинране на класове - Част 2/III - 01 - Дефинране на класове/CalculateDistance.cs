using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace III___01___Дефинране_на_класове
{
    static class CalculateDistance
    {
        public static double calct(Point3D point1, Point3D point2)
        {

            return Math.Sqrt(
      (point2.X - point1.X) * (point2.X - point1.X) +
      (point2.Y - point1.Y) * (point2.Y - point1.Y) +
      (point2.X - point1.Z) * (point2.Z - point1.Z));

        }
    }
}
