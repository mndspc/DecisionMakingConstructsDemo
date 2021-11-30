using System;

namespace DecisionMakingConstructs
{
    //  This program Shows how to work with multiple conditions using if-else if-else
    class EfElseIfDemo
    {
        static void Main()
        {
            // Using if-else if-else we can check multiple conditions
            Console.Write("Enter Item Name:");
            string Item = Console.ReadLine();
            Item= Item.ToLowerInvariant();
            if (Item == "food")
            {
                Console.WriteLine("1%");
            }
            else if (Item == "ornments")
            {
                Console.WriteLine("5%");
            }
            else if (Item== "services")
            {
                Console.WriteLine("18%");
            }
            else
            {
                Console.WriteLine("Invalid Item");
            }

            Console.ReadLine();
        }
    }
}
