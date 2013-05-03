using System;

namespace Methods
{
    public class Student
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string City { get; set; }
        public string Hobby { get; set; }

        public Student(string firstName, string lastName, string birthDate, string city = null, string hobby = null)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.City = city;
            this.Hobby = hobby;
            DateTime parsedDataTime;

            if (!DateTime.TryParse(birthDate, out parsedDataTime))
            {
                throw new ArgumentException("Date format is incorect !");
            }
        }
        public bool IsOlderThan(Student student)
        {
            bool isOlder = false;
            DateTime firstStudent = this.BirthDate;
            DateTime secondStudent = student.BirthDate;

            if (DateTime.Compare(firstStudent, secondStudent) < 0)
            {
                isOlder = true;
            }

            return isOlder;
        }
    }
}