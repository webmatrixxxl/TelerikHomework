using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    public class Course : School
    {
        private List<Student> students;
        private byte maxStudents = 30;

        public Course(string name)
            : base(name)
        {
        }

        public List<Student> Students
        {
            get
            {
                return this.students;
            }
            private set
            {
                this.students = value;
            }
        }

        public void AddStudent(Student students)
        {
            if (this.students.Count<=maxStudents)
            {
                this.students.Add(students);
            }
            else
            {
                throw new ArgumentOutOfRangeException("Curse can't have more then " + maxStudents + " in class.");
            }
        }

        public void RemoveStudent(Student students)
        {
            this.students.Remove(students);
        }
    }
}
