using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    public class Student : School
    {
        private string name;
        private int id = 999;

        public Student(string name, int id)
            : base(name)
        {
            this.Name = name;
            this.id = GenerateId();
        }

        public int Id
        {
            get
            {
                return this.id;
            }
            private set
            {
                this.id = value;
            }
        }

        private int GenerateId()
        {
            this.id++;

            return this.id;
        }
    }
}
