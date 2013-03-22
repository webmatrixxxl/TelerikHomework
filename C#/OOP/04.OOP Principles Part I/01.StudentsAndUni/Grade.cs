using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.StudentsAndUni
{
    public class Grade : School, ICommentable
    {
        private string classID{ get; set; }
        private List<Teacher> teachers = new List<Teacher>();
        private List<Student> students = new List<Student>();

        public string comment { get; set; }

        public Grade(string ClassID)
        {
            this.classID = classID;
        }
        public Grade AddStudent(params Student[] students)
        {
            foreach (Student student in students)
                this.students.Add(student);

            return this;
        }

        public Grade RemoveStudent(Student student)
        {
            this.students.Remove(student);

            return this;
        }

        public Grade AddTeacher(params Teacher[] teachers)
        {
            foreach (Teacher teacher in teachers)
                this.teachers.Add(teacher);

            return this;
        }

        public Grade RemoveTeacher(Teacher teacher)
        {
            this.teachers.Remove(teacher);

            return this;
        }

    }
}
