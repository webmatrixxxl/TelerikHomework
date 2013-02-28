using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace III___01___Дефинране_на_класове___Част_1
{
    class Call
    {
        //<fields>
        private DateTime data = DateTime.Now;
        private string phoneNumber;
        private int duration;

        //</fields>

        //<construcotrs>
        public Call(string phoneNumber, int duration)
        {
           
            this.phoneNumber = phoneNumber;
            this.duration = duration;

        }
        //</constructors>

        //<properties>
        public DateTime Data
        {
            get
            {
                return this.data;
            }
            
        }
        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }

        }
        public int Duration
        {
            get
            {
                return this.duration;
            }

        }
        //</properties>

        
    }
}
