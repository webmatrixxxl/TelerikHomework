using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University_CodeFirst.Models
{
    [Table("Courses")]
    public class Course
    {
        private ICollection<Student> students;
        private ICollection<Homework> homeworks;
       
        public int CourseId { get; set; }
     
        public string Name { get; set; }

        public string Description { get; set; }

        public string Materials { get; set; }

        public Course()
        {
            this.students = new HashSet<Student>();
            this.homeworks = new HashSet<Homework>();
        }

        public virtual ICollection<Student> Students
        {
            get { return this.students; }
            set { this.students = value; }
        }

        public virtual ICollection<Homework> Homeworks
        {
            get { return this.homeworks; }
            set { this.homeworks = value; }
        }


    }
}
