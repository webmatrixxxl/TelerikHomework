using System;
using System.Linq;

namespace _11.ImplementLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicList shoppingList = new DynamicList();
            shoppingList.Add("Milk");
            shoppingList.Add("Honey");
            shoppingList.Add("Olives");
            shoppingList.Add("Beer");
            shoppingList.Remove("Olives");

            Console.WriteLine("We need to buy:");

            for (int i = 0; i < shoppingList.Count; i++)
            {
                Console.WriteLine(shoppingList[i]);
            }

            Console.WriteLine("Do we have to buy Bread? " + shoppingList.Contains("Bread"));
        }
    }
}