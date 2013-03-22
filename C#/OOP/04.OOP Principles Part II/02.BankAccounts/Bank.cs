using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankAccounts
{
    class Bank
    {
        private readonly List<Account> accounts = new List<Account>();

        public string Name { get; private set; }

        public Bank(string name)
        {
            this.Name = name;
        }

        public Bank AddAccount(params Account[] accounts)
        {
            foreach (Account account in accounts)
                this.accounts.Add(account);

            return this;
        }

        public Bank RemoveAccout(Account account)
        {
            this.accounts.Remove(account);

            return this;
        }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();

            info.AppendLine("Bank: " + this.Name);

            foreach (Account account in accounts)
                info.AppendLine(account.ToString());

            return info.ToString();
        }
    }
}
