using System;
using System.Collections.Generic;

namespace GroceryListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> groceryItems = new List<string>
            {
                "Milk",
                "Bread",
                "Eggs",
                "Butter",
                "Cheese",
                "Orange"
            };

            Console.WriteLine("Grocery List:");
            foreach (var item in groceryItems)
            {
                Console.WriteLine(item);
            }
        }
    }
}
