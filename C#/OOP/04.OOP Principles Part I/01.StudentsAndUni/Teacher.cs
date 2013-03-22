using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.StudentsAndUni
{
    public class Teacher : People, ICommentable
    {

        private readonly List<Disciplines> disciplines = new List<Disciplines>();
        public string comment { get; set; }

        public Teacher(string name)
        {
            this.name = name;
        }

        public Teacher AddDiscipline(params Disciplines[] discipline)
        {
            foreach (var item in discipline)
                this.disciplines.Add(item);

            return this;
        }

        public Teacher RemoveDiscipline(Disciplines discipline)
        {
            this.disciplines.Remove(discipline);

            return this;
        }


    }
}
