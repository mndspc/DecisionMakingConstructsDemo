using System;


namespace DecisionMakingConstruct
{
    //  This program demo. how to use logical && and logical || oprators
    class LogicalAndOr
    {
        static void Main()
        {
            Console.Write("Enter Highest Qualification(UG/PG):");
            string qualification = Console.ReadLine();
            qualification = qualification.ToLowerInvariant();

            Console.Write("Enter Experience in (Months):");
            int months = int.Parse(Console.ReadLine());

            if(qualification=="pg" || months >= 12)
            {
                Console.WriteLine("You are eligible to appear interview");

            }
            else
            {
                Console.WriteLine("You are not eligible to appear for interview");
            }
            Console.ReadLine();
        }
    }
}
