using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankAccounts
{
    class DepositAccount : Account
    {
        public DepositAccount(Customer customer, decimal balance, decimal interest)
            : base(customer, balance, interest)
        {
        }

        public DepositAccount Deposit(decimal amount)
        {
            this.balance += amount;

            return this;
        }

        public override decimal CalculateInterest(decimal months)
        {
            if (0 < this.balance && this.balance < 1000)
                return 0;

            return base.CalculateInterest(months);
        }

        public override string ToString()
        {
            return base.ToString("Deposit Account");
        }
    }
}
