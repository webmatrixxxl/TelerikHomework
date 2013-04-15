namespace _01.RefactorWellNamed
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class BoolExtenstion
    {
        private const int MaxCount = 6;

        public static void Main()
        {
            BoolExtenstion @bool = new BoolExtenstion();
            @bool.PrintBoolAsTaxt(true);
        }

        public void PrintBoolAsTaxt(bool @bool)
        {
            string boolToString = @bool.ToString();
            Console.WriteLine(boolToString);
        }
    }

}