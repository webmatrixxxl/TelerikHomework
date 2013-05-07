using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace ComparePerfArithmeticPrimitiveValues
{
    public class TestPerformance
    {
        static void Main()
        {
            AddMethods.AddDecimal(4m, 500000m);
            AddMethods.AddDouble(4d, 500000d);
            AddMethods.AddFloat(4f, 500000f);
            AddMethods.AddInt(4, 500000);
            AddMethods.AddLong(4L, 500000L);

            SubstractMethods.SubstractDecimal(500000m, 4m);
            SubstractMethods.SubstractDouble(500000d, 4d);
            SubstractMethods.SubstractFloat(500000f, 4f);
            SubstractMethods.SubstractInt(500000, 4);
            SubstractMethods.SubstractLong(500000L, 4L);

            MultiplyMethods.MultiplyDecimal(2m, 500000m, 2m);
            MultiplyMethods.MultiplyDouble(2d, 500000d, 5d);
            MultiplyMethods.MultiplyFloat(2f, 500000f, 5f);
            MultiplyMethods.MultiplyInt(2, 500000, 5);
            MultiplyMethods.MultiplyLong(2L, 500000L, 5L);

            DivideMethods.DivideDecimal(500000m, 4m, 2m);
            DivideMethods.DivideDouble(500000d, 4d, 2d);
            DivideMethods.DivideFloat(500000f, 4f, 2f);
            DivideMethods.DivideInt(500000, 4, 2);
            DivideMethods.DivideLong(500000L, 4L, 2L);
        }
    }
}
