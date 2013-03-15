using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.StudentsAndUni
{
    public class Teachers : People
    {
        public List<Disciplines> Discplines { get; set; }

        public Teachers(string name, params List<Disciplines> disciplines)
        {
            this.Discplines = disciplines;
            this.name = name;
        }
    }
}
