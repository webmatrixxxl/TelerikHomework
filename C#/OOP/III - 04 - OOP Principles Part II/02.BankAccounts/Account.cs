using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankAccounts
{
    abstract class Account
    {
        public Customer customer { get; protected set; }
        public decimal balance { get; protected set; }
        public decimal interestRate { get; protected set; } //monthly based

        public Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.customer = customer;
            this.balance = balance;
            this.interestRate = interestRate;
        }


        public Account Withdraw(decimal amount)
        {
            this.balance -= amount;

            return this;
        }

        public virtual decimal CalculateInterest(decimal months)
        {
            if (!(months > 0))
                return 0;

            return this.balance * this.interestRate * months;
        }

        public string ToString(string type)
        {
            List<string> info = new List<string>();

            info.Add(String.Empty); // Add empty line
            info.Add("Type: " + type);
            info.Add("Customer: ");
            info.Add(this.customer.ToString());
            info.Add("Balance: " + this.balance);
            info.Add("Interest rate: " + this.interestRate);

            return String.Join(Environment.NewLine, info);
        }

    }
}
