using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace III___01___Дефинране_на_класове
{
    static class PathStorage
    {
        //<fields>
        private static int count = 0;
        private static string fileName = "numbers.txt";
        //</fields>

        //<methods>
        public static void Save(List<Point3D> point, string saveName)
        {
            count++;
            StreamWriter streamWriter;
            if (count == 1)
            {
                streamWriter =
    new StreamWriter(fileName, false);
            }
            else
            {
                streamWriter =
    new StreamWriter(fileName, true);
            }

            using (streamWriter)
            {
                streamWriter.Write(saveName);
                foreach (var item in point)
                {
                    streamWriter.Write(" " + item.X + " " + item.Y + " " + item.Z + ", ");
                }
                streamWriter.WriteLine("");

                streamWriter.Close();
            }


        }

        public static List<Point3D> Load(string loadName)
        {

            List<Point3D> Point3DList = new List<Point3D>();

            StreamReader streamReader =
     new StreamReader(fileName);
            int index;
            using (streamReader)
            {

                string collection;
                string line = streamReader.ReadLine();

                while (line != null)
                {

                    index = line.IndexOf(loadName);
                    line = streamReader.ReadLine();
                    if (index >= 0)
                    {
                        collection = line;
                        collection = collection.Substring(loadName.Length, collection.Length - loadName.Length).Trim();

                        string[] collectionArray = collection.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (var item in collectionArray)
                        {

                            string[] xyzArray = item.Trim().Split(' ');
                            Point3D pointLoad = new Point3D(int.Parse(xyzArray[0]), int.Parse(xyzArray[1]), int.Parse(xyzArray[0]));

                            Point3DList.Add(pointLoad);

                        }

                        return Point3DList;
                    }

                }

                streamReader.Close();
            }
            return Point3DList;

        }
        //</methods>


    }
}
