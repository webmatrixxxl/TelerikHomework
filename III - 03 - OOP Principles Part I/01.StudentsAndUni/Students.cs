using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.StudentsAndUni
{
    public class Students : People
    {
        private int id{get; set;}

        public Students(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

    }
}
