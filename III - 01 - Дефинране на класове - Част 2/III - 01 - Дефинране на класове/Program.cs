using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace III___01___Дефинране_на_класове
{
    class Program
    {
        static void Main(string[] args)
        {
            Point3D point1 = new Point3D(1,1,1);
            Point3D point2 = new Point3D(1,1,1);
            Console.WriteLine(CalculateDistance.calct(point1, point2));
            Path collection = new Path();
            collection.AddPoint(point1, point2);
            

        }
    }
}
