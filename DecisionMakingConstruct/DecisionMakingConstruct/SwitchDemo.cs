using System;


namespace DecisionMakingConstruct
{
    //  This program demo. how to write switch-case
    class SwitchDemo
    {
        static void Main()
        {
            Console.Write("Enter Item:");
            string Item = Console.ReadLine();
            Item = Item.ToLowerInvariant();
            switch (Item)
            {
                case "food"     : Console.WriteLine("1%");
                                break;
                case "ornments":Console.WriteLine("5%");
                                break;
                case "services":Console.WriteLine("18%");
                                break;
                default: Console.WriteLine("Invalid Item");
                                break;  
            }
            Console.ReadLine();
        }
    }
}
