using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University_CodeFirst.Models
{
    [Table("Homeworks")]
    public class Homework
    {
        public int HomeworkId { get; set; }

        public string Content { get; set; }


        public DateTime TimeSent { get; set; }

        public DateTime DeadLine { get; set; }

        public int CourseId { get; set; }
        public virtual Course Course { get; set; }

        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
    }
}
