using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.StudentsAndUni
{
    public class Teachers : People
    {
        public List<Disciplines> Discplines { get; set; }

        public Teachers(string name)
        {
            this.Discplines = new List<Disciplines>();
            this.name = name;
        }
    }
}
