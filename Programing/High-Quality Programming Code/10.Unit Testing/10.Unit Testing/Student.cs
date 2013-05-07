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
        private static int minId = 10000;
        private static int maxId = 99999;
        private int id = minId;

        public Student(string name)
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
        }

        private int GenerateId()
        {
            if (this.id >= minId && this.id <= maxId)
            {
                this.id++;
                return this.id;

            }
            else
            {
                throw new ArgumentOutOfRangeException("Student ID out of range " + minId + " to " + maxId);
            }
        }
    }
}
