using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height. 
//  Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of 
//  the figure (height*width for rectangle and height*width/2 for triangle). Define class Circle and suitable
//  constructor so that at initialization height must be kept equal to width and implement the CalculateSurface()
//  method. Write a program that tests the behavior of  the CalculateSurface() method for different shapes 
//  (Circle, Rectangle, Triangle) stored in an array.


namespace _01.AbstractClassShape
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Object> array = new List<object>() {
               new Circle(10),
               new Rectangle(10, 5),
               new Triangle(10, 5)

            };

            Circle temp = array[0] as Circle;
            Console.WriteLine(temp.height);
        }
    }
}
