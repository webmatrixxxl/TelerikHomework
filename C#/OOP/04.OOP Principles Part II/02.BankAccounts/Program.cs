using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range. 
//  It should hold error message and a range definition [start … end].
//  Write a sample application that demonstrates the InvalidRangeException<int> and InvalidRangeException<DateTime>
//  by entering numbers in the range [1..100] and dates in the range [1.1.1980 … 31.12.2013].


namespace _02.BankAccounts
{
    class Program
    {
        static void Main(string[] args)
        {
              Console.WriteLine(
                new Bank("?").AddAccount(
                    new DepositAccount(
                        new Company("Колио Терориста"), 0, .5M
                    ).
                    Deposit(150).
                    Withdraw(50),

                    new LoanAccount(
                        new Individual("Сашо Александров"), 50, .07M
                    ).
                    Withdraw(20),

                    new MortgageAccount(
                        new Individual("Гошо Туршията"), 0, .05M
                    )
                )
            );
        }
    }
}
