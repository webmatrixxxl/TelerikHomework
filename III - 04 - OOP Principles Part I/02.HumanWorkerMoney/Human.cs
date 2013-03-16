using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanWorkerMoney
{
    abstract class Human
    {
        public string firstName { get; private set; }
        public string lastName { get; private set; }

        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        protected string ToString(string suffix)
        {
            StringBuilder info = new StringBuilder();

            info.AppendFormat("Name: {0} {1}", this.firstName, this.lastName).AppendLine();

            info.AppendLine(suffix).Replace(
                Environment.NewLine, Environment.NewLine
            );

            return info.TrimEnd().ToString();
        }
    }
}
