using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankAccounts
{
    class MortgageAccount : Account
    {
         public MortgageAccount(Customer customer, decimal balance, decimal interest)
        : base(customer, balance, interest)
    {
    }

    public override decimal CalculateInterest(decimal months)
    {
        if (this.customer is Individual)
            return base.CalculateInterest(months - 6);

        if (this.customer is Company)
            return base.CalculateInterest(Math.Min(months, 12) / 2 + Math.Max(months - 12, 0));

        return base.CalculateInterest(months);
    }

    public override string ToString()
    {
        return base.ToString("Mortgage Account");
    }
    }
}
