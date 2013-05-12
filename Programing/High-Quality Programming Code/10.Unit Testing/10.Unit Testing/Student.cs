using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCourses
{
    public class Student : School
    {
        public const int minId = 9999;
        public const int maxId = 99999;
        private string name;
        private static int currentId = minId;
        private int id;

        public Student(string name)
            : base(name)
        {
            this.Name = name;
            this.id = GenerateId();
        }

        public static int CurrentId
        {
            get
            {
                return currentId;
            }
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
            if (currentId >= minId && currentId <= maxId)
            {
                currentId++;
                return currentId;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Student ID out of range " + minId + " to " + maxId);
            }
        }
    }
}