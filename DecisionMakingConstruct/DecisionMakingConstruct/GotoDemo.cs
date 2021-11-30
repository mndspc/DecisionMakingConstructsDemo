using System;


namespace DecisionMakingConstruct
{   
    //  This program demo. how to change control flow of program using goto label.
    class GotoDemo
    {
        static void Main()
        {
start:      Console.Write("Enter Item:");
            string Item = Console.ReadLine();
            Item = Item.ToLowerInvariant();
            switch (Item)
            {
                case "food":
                    Console.WriteLine("1%");
                    break;
                case "ornments":
                    Console.WriteLine("5%");
                    break;
                case "services":
                    Console.WriteLine("18%");
                    break;
                default:
                    Console.WriteLine("Invalid Item");
                    break;
            }
            Console.WriteLine("Do you want to continue?:(yes/no)");
            string res = Console.ReadLine();
            res = res.ToLowerInvariant();
            if (res == "yes")
            {
                goto start;
            }

            Console.ReadLine();
        }
    }
}
