using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.StudentsAndUni
{
    public class Student : People, ICommentable
    {
        private int id{get; set;}
        public string comment { get; set; }
        public Student(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

    }
}
