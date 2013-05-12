using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCourses
{
    public class Course : School
    {
        private List<Student> courseStudents = new List<Student>();
        private const byte MaxStudents = 30;

        public Course(string name)
            : base(name)
        {
        }

        public Course(string name, List<Student> students)
            : base(name)
        {
            this.courseStudents = new List<Student>();
        }

        public Course(string name, Student student)
            : base(name)
        {
            this.courseStudents.Add(student);
        }


        public List<Student> Students
        {
            get
            {
                return this.courseStudents;
            }
            private set
            {
                this.courseStudents = value;
            }
        }

        public void AddStudent(Student students)
        {
            bool studentFound = this.CheckIfStudentIsFound(students);

            if (studentFound)
            {
                throw new ArgumentException("The student has been added already!");
            }

            if (this.courseStudents.Count <= MaxStudents - 1)
            {
                this.courseStudents.Add(students);
            }
            else
            {
                throw new ArgumentOutOfRangeException("Curse can't have more then " + MaxStudents + " in class.");
            }
        }

        public void RemoveStudent(Student students)
        {
            this.courseStudents.Remove(students);
        }

        private bool CheckIfStudentIsFound(Student student)
        {
            bool studentFound = false;
            for (int i = 0; i < this.Students.Count; i++)
            {
                if (this.Students[i].Name == student.Name)
                {
                    studentFound = true;
                }
            }

            return studentFound;
        }
    }
}