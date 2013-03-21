using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    abstract class Animal
    {

        public int age { get; private   set; }
        public string name { get; private set; }
        public Sex sex { get; private set; }
        public string sound { get;  set; }

        public Animal(int age, string name, Sex sex)
        {
            this.age = age;
            this.name = name;
            this.sex = sex;
        }

   

        public abstract string Sound ();
    }
}
