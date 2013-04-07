using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace III___01___Дефинране_на_класове
{

    public class VersionAttribute : System.Attribute
    {
        private double version;

        public VersionAttribute(double version)
        {
            this.version = version;
        }

        public double Version
        {
            get
            {
                return this.version;
            }
        }
    }

}
