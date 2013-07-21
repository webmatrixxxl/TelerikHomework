using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University_CodeFirst.Models;

namespace University_CodeFirst.Data
{
    public class University_CodeFirstContext : DbContext
    {
        public University_CodeFirstContext()
            //the name of the base
            : base("UniversityDb")
        {
        
        }
        public DbSet<Course> Course { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Homework> Homewrok { get; set; }

    }
}
