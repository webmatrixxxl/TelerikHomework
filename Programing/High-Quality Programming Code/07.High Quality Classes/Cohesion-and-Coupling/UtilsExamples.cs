using System;

namespace CohesionAndCoupling
{
    class DistanceExamples
    {
        static void Main()
        {
            Console.WriteLine(File.GetFileExtension("example"));
            Console.WriteLine(File.GetFileExtension("example.pdf"));
            Console.WriteLine(File.GetFileExtension("example.new.pdf"));

            Console.WriteLine(File.GetFileNameWithoutExtension("example"));
            Console.WriteLine(File.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(File.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine(
                "Distance in the 2D space = {0:f2}",
                Distance.CalcDistance2D(1, -2, 3, 4));
            Console.WriteLine(
                "Distance in the 3D space = {0:f2}",
                Distance.CalcDistance3D(5, 2, -1, 3, -6, 4));

            Console.WriteLine("Volume = {0:f2}", Distance.CalcVolume(9, 7, 8));
            Console.WriteLine("Diagonal XYZ = {0:f2}", Distance.CalcDiagonalXYZ(3, 4, 6));
            Console.WriteLine("Diagonal XY = {0:f2}", Distance.CalcDiagonalXY(4, 3));
            Console.WriteLine("Diagonal XZ = {0:f2}", Distance.CalcDiagonalXZ(3, 5));
            Console.WriteLine("Diagonal YZ = {0:f2}", Distance.CalcDiagonalYZ(4, 5));
        }
    }
}
