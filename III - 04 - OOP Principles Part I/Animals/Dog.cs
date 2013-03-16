using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Dog : Animal
    {
        public Dog(int age, string name, string sex)
            : base(age, name, sex)
        { }
        public override void Sound()
        {
            Console.WriteLine("Dog say bau bau");
            
        }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();

            info.AppendLine("Dog name: " + this.name);
            info.AppendLine("Dog age: " + this.age);
            info.AppendFormat("Dog sex: " + this.sex);
            info.AppendFormat("Dog sound like: " + Sound()).AppendLine();

            return base.ToString(info.ToString());
        }
    }
}
