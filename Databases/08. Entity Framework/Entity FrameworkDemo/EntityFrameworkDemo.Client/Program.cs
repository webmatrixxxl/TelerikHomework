﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkDemo.Model;

namespace EntityFrameworkDemo.Client
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var db = new NORTHWNDEntities())
            {
                //var customers = db.Customers.Where(x => x.Country == "UK")
                //.OrderBy(x => x.ContactName)
                //.Where(x => x.City == "London").Select(x => new {x.Address});

                //foreach (var item in customers)
                //{
                //    Console.WriteLine(item.Address);
                //}


                //var region = new Region
                //{
                //    RegionDescription = "Dopsi"
                //};

                //db.Regions.Add(region);
                //db.SaveChanges();



                //var cust = db.Customers.Find("ALFKI");
                //Console.WriteLine(cust);

                //var data = db.Customers.
                //    Join(db.Suppliers,
                //    (c => c.Country), (s => s.Country), (c, s) =>
                //        new
                //        {
                //            Customer = c.CompanyName,
                //            Supplier = s.CompanyName,
                //            Cuntry = c.Country
                //        });

                //Console.WriteLine(data.GetType)

                // Task 03. Write a method that finds all customers who have orders made in
                // 1997 and shipped to Canada.


                //var getCustomersOrders = db.Orders.
                //    Where(o => o.OrderDate.Value.Year == 1997 && o.ShipCountry == "Canada").
                //    Select(o => o.Customer).
                //    Distinct().
                //    ToList();

                //foreach (var item in getCustomersOrders)
                //{
                //    Console.WriteLine(item.ContactName);
                //}

                // Task 04. Implement previous by using native SQL query and executing it through the DbContext.

                //var result = FindAllCustomersSQLquery(1997, "Canada");
                //    foreach (var item in result)
                //{
                //    Console.WriteLine(item);
                //}

                // Tasl 05. Write a method that finds all the sales by specified region and period (start / end dates).

                //var result = FindsAllSalesByRegionAndPeriod("SP", "Jan 1, 1995", "Jan 1, 1999");

                //foreach (var item in result)
                //{
                //    Console.WriteLine(item.Customer.CompanyName);
                //}

                foreach (var product in db.Products)
                {
                    Console.WriteLine("Product: {0}; Company Name: {1}; Categoty Name: {2}",
                        product.ProductName,
                        product.Supplier.CompanyName,
                        product.Category.CategoryName);
                }
            }
        }

        private static IEnumerable<string> FindAllCustomersSQLquery
               (int year, string country)
        {
            NORTHWNDEntities db = new NORTHWNDEntities();
            string nativeSqlQuery =
                "SELECT DISTINCT c.ContactName " +
                "From Customers c " +
                "JOIN Orders o " +
                "ON c.CustomerID = o.CustomerID " +
                "WHERE o.ShipCountry ='" + country + "' " +
                "AND FORMAT(o.OrderDate, 'yyyy') = '" + year + "'";

            var customers =
                db.Database.SqlQuery<string>(nativeSqlQuery);
            return customers;
        }

        private static List<Order> FindsAllSalesByRegionAndPeriod
               (string region, string start, string end)
        {
            var parsedStart = DateTime.Parse(start);
            var parsedEnd = DateTime.Parse(end);

            NORTHWNDEntities db = new NORTHWNDEntities();

            var result = db.Orders.
                Where(o => o.ShipRegion == region && o.OrderDate.HasValue && (o.OrderDate.Value >= parsedStart && o.OrderDate.Value <= parsedEnd));

            return result.ToList();
        }
    }
}
