using System;


namespace DecisionMakingConstruct
{
    //  This program demo. how to nest if conditions.
    class NestedIfDdemo
    {
        static void Main()
        {
            Console.Write("Enter Highest Qualification(UG/PG):");
            string qualification = Console.ReadLine();
            qualification = qualification.ToLowerInvariant();

        
            if (qualification == "pg")
            {
                Console.Write("Enter Experience in (Months):");
                int months = int.Parse(Console.ReadLine());

                if (months >= 12)
                {
                    Console.WriteLine("You are eligible for interview");
                }
                else
                {
                    Console.WriteLine("Exprience must be greater than equal to 12");
                }
            }
            else
            {
                Console.WriteLine("Qualification must be PG");
            }
            Console.ReadLine();
        }
    }
}
