using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadCompanyInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please ENTER Company Info:");
            Console.Write("Enter Company name:");
            string companyName = Console.ReadLine();
            Console.Write("Enter Company site:");
            string companySite = Console.ReadLine();
            Console.Write("Enter Company phone number:");
            string companyPhone = Console.ReadLine();
            Console.Write("Enter Company FAX number:");
            string companyFax = Console.ReadLine();
            Console.Write("Enter Company Manager first name:");
            string managerFirstName = Console.ReadLine();
            Console.Write("Enter Company Manager last name:");
            string managerLastName = Console.ReadLine();
            Console.Write("Enter Company Manager age:");
            string managerAge = Console.ReadLine();
            Console.Write("Enter Company Manager phone:");
            string managerPhone = Console.ReadLine();
            Console.WriteLine("     Company INFO: \nName: {0}\nPhone: {1}\nFax: {2}\nSite: {3}\n     Manager INFO:\nFirs name: {4}\nLast name: {5}\nAge: {6}\nPhone: {7}",companyName,companyPhone,companyFax,companySite,managerFirstName,managerLastName, managerAge, managerPhone);
        } 
    }
}
