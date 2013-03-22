using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Cat : Animal
    {
        public Cat(int age, string name, Sex sex, string sound)
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

            info.AppendLine("Cat name: " + this.name);
            info.AppendLine("Cat age: " + this.age);
            info.AppendLine("Cat sex: " + this.sex);
            info.AppendFormat("Cat sound like: {0}", Sound());


            return info.ToString();
        }
    }
}
