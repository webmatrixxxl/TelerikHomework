using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University_CodeFirst.Models
{
    [Table("Students")]
    public class Student
    {
        private ICollection<Course> courses;
        private ICollection<Homework> homeworks;

        public int StudentID { get; set; }

        public string Name { get; set; }

        public int Number { get; set; }

        public Student()
        {
            this.courses = new HashSet<Course>();
            this.homeworks = new HashSet<Homework>();
        }

        public virtual ICollection<Course> Courses
        {
            get { return this.courses; }
            set { this.courses = value; }
        }

        public virtual ICollection<Homework> Homeworks
        {
            get { return this.homeworks; }
            set { this.homeworks = value; }
        }

    }
}
