using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanWorkerMoney
{
    class Student : Human
    {
        public string grade { get; private set; }

        public Student(string firstName, string lastName, string grade)
            : base(firstName, lastName)
        {
            this.grade = grade;
        }

        public override string ToString()
        {
            return base.ToString("Grade: " + this.grade);
        }
    }
}
