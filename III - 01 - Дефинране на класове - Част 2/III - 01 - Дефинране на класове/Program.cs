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
            Point3D point1 = new Point3D(2,3,4);
            Point3D point2 = new Point3D(1,1,1);
            Console.WriteLine(CalculateDistance.calct(point1, point2));
            Path collection = new Path();
            collection.AddPoint(point1, point2);

            PathStorage.Save(collection.PathList, "Colection1");
            PathStorage.Save(collection.PathList, "Colection2");
            Console.WriteLine("Load \"Colection1\"");
            for (int i = 0; i < PathStorage.Load("Colection1").Count; i++)
            {
                Console.WriteLine("Point {0} cordinates: X={1}, Y={2}, Z={3}", i, PathStorage.Load("Colection1")[i].X, PathStorage.Load("Colection1")[i].Y, PathStorage.Load("Colection1")[i].Z);
            }
            GenericList<int> LIST = new GenericList<int>();
            LIST.Insert(51, 2);
            LIST.Insert(51, 1);
            LIST.Insert(51, 3);
            LIST.Insert(51, 6);
            LIST.AddElement(111);

            Console.WriteLine(LIST.Access(4));
            Console.WriteLine("ss"+LIST.array.Length + "Golemina na masiva");
            LIST.ClearArray();
            Console.WriteLine(LIST.Access(4));
           
            

            
        }
    }
}
