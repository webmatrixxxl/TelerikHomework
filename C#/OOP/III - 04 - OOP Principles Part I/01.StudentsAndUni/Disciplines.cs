using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.StudentsAndUni
{
    public class Disciplines : School
    {
        public string name { get; set; }

        public string comment { get; set; }

        public int numOfLectures { get; set; }

        public int numOfExercises { get; set; }

        public Disciplines(string name, int numOfLectures, int numOfExercises)
        {
            this.name = name;
            this.numOfExercises = numOfExercises;
            this.numOfLectures = numOfLectures;
        }
    }
}
