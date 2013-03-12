using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace III___03___ламбда__LINQ___Част_2
{
    static class Substr
    {
        public static StringBuilder Substring(this StringBuilder input, int index, int length)
        {
            string output = input.ToString();
            output = output.Substring(index,length);
            StringBuilder newString = new StringBuilder(output);
            return newString;
        }
    }
}
