using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FirstAndLastNamesOfStudenstAge
{
    class students
    {
        private string firstName;
        private string lastName;
        private int age;

        public students(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                this.firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                this.lastName = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                this.age = value;
            }
        }

    }
}
