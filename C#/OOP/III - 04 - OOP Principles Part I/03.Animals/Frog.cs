using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Frog : Animal
    {
         public Frog(int age, string name, Sex sex, string sound)
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

            info.AppendLine("Frog name: " + this.name);
            info.AppendLine("Frog age: " + this.age);
            info.AppendLine("Frog sex: " + this.sex);
            info.AppendFormat("Frog sound like: {0}", Sound());
       

            return info.ToString();
        }
    }
}
