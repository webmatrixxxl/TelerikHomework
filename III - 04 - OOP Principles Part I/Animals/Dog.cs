using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Dog : Animal
    {
        public Dog(int age, string name, string sex, string sound)
            : base(age, name, sex)
        {
            this.sound = sound;
        }
        public override string Sound()
        {
            return this.sound;
            
        }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();

            info.AppendLine("Dog name: " + this.name);
            info.AppendLine("Dog age: " + this.age);
            info.AppendFormat("Dog sex: " + this.sex);
            info.AppendFormat("Dog sound like: {0}", Sound());
       

            return info.ToString();
        }
    }
}
