using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ClassStudentAndOvrObject
{
    class Student : IComparable, IComparable<Student>
    {
        private string p1;
        private string p2;
        private string p3;
        private string p4;
        private int p5;
        private int p6;
        private int p7;
        private Enumeration.Specialty specialty1;
        private Enumeration.University university1;
        private Enumeration.Faculty faculty1;

        public string firstName { get; private set; }
        public string middleName { get; private set; }
        public string lastName { get; private set; }
        public int SSN { get; private set; }
        public string address { get; private set; }
        public int mobilePhone { get; private set; }
        public string email { get; private set; }
        public int course { get; private set; }
        public Enumeration.University university { get; set; }
        public Enumeration.Faculty faculty { get; set; }
        public Enumeration.Specialty specialty { get; set; }

        public Student(string firstName, string middleName, string lastName, int SSN, string address, int mobilephone, string email, Enumeration.University university, Enumeration.Faculty faculty, Enumeration.Specialty speciaty)
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.address = address;
            this.mobilePhone = mobilePhone;
            this.course = course;
            this.SSN = SSN;
            this.specialty = specialty;
            this.university = university;
            this.faculty = faculty;
        }



        public override string ToString()
        {
            StringBuilder build = new StringBuilder();
            build.AppendLine(this.firstName);
            build.AppendLine(this.middleName);
            build.AppendLine(this.lastName);
            build.AppendLine(this.address);
            build.AppendLine(this.mobilePhone.ToString());
            build.AppendLine(this.course.ToString());
            build.AppendLine(this.SSN.ToString());
            build.AppendLine(this.specialty.ToString());
            build.AppendLine(this.university.ToString());
            build.AppendLine(this.faculty.ToString());

            return build.ToString();
        }

        public override bool Equals(object param)
        {
            Student student = param as Student;

            if ((object)student == null)
            {
                return false;
            }

            if (!Object.Equals(this.firstName, student.firstName))
            {
                return false;
            }

            if (!Object.Equals(this.lastName, student.lastName))
            {
                return false;
            }
            if (this.SSN != student.SSN)
            {
                return false;
            }

            return true;
        }

        public static bool operator ==(Student student1, Student student2)
        {
            return Student.Equals(student1, student2);
        }

        public static bool operator !=(Student student1, Student student2)
        {
            return !(Student.Equals(student1, student2));
        }

        public override int GetHashCode()
        {
            return mobilePhone.GetHashCode() ^ SSN.GetHashCode();
        }

        public Student Clone()
        {
            Student clone = new Student
                (
                this.firstName,
                this.middleName,
                this.lastName,
                this.address,
                this.mobilePhone,
                this.course,
                this.SSN,
                this.specialty,
                this.university,
                this.faculty
                );
            return clone;
        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }

        public int CompareTo(Student student)
        {
            if (this.lastName != student.lastName)
            {
                return (String.Compare(this.lastName, student.lastName));
            }
            if (this.firstName != student.firstName)
            {
                return (String.Compare(this.firstName, student.firstName));
            }
            if (this.SSN != student.SSN)
            {
                return (this.SSN - student.SSN);
            }
            return 0;
        }    

    }
}
