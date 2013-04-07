using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace III___01___Дефинране_на_класове
{
    struct Point3D
    {
        //<fields>

        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        private static readonly Point3D pointO = new Point3D(0, 0, 0);
        //</fields>

        //<constructor>

        public Point3D(int X, int Y, int Z):this()
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }
        //</constructor>

        //<property>
        public static Point3D PointO
        {
            get
            {
                return  Point3D.pointO;
            }
        }
        //</property>
    }
}
