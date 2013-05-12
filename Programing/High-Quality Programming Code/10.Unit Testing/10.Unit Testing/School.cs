using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCourses
{
    public class School
    {
        private string name;
        private List<Student> schoolStudents = new List<Student>();
        private List<Course> courses = new List<Course>();


        public School(string name)
        {
            this.Name = name;
        }

        public School(string name, List<Student> students):this(name)
        {
            this.schoolStudents = students;
        }

        public School(string name, Student students)
            : this(name)
        {
            this.schoolStudents.Add(students);
        }


        public List<Student> SchoolStudents
        {
            get
            {
                return this.schoolStudents;
            }
            set
            {
                this.schoolStudents = value;
            }
        }

        public List<Course> Courses
        {
            get
            {
                return this.courses;
            }
            set
            {
                this.courses = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            protected set
            {
                if (value != null && value != string.Empty)
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentNullException("School name can't be null or empty!");
                }
            }
        }
    }
}