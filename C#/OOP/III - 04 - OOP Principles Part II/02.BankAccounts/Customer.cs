using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankAccounts
{
    class Customer
    {
        public string customerName { get; private set; }

        public Customer(string customerName)
        {
            this.customerName = customerName;
        }

        public override string ToString()
        {
            return String.Format("Type: {0}; Name: {1}", this.GetType(), this.customerName);
        }
    }
}
