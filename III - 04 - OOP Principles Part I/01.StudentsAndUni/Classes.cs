using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.StudentsAndUni
{
    public class Classes : School
    {
        private string classID{ get; set; }
        List<Teachers> teachers = new List<Teachers>();
        List<Students> students = new List<Students>();

        public Classes(string ClassID, List<Teachers> teachers, List<Students> students)
        {
            this.classID = classID;
            this.teachers = teachers;
            this.students = students;
        }

    }
}
