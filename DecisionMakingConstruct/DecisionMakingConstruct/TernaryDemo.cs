using System;


namespace DecisionMakingConstruct
{
    //  This program demo. how to use ternary operator.
    class TernaryDemo
    {
        static void Main()
        {
            Console.Write("Enter Annual Income:");
            double annualIncome = Convert.ToDouble(Console.ReadLine());
            var result= annualIncome >= 280000 ? "You are liable to pay I.T." : "You are not liable to pay I.T.";

           //var result = annualIncome >= 280000 ? Message1() : Message2() ;
            Console.WriteLine(result) ;
            Console.ReadLine();
        }

        public static string Message1()
        {
            return "You are liable to pay I.T.";
        }

        public static string Message2()
        {
            return "You are not liable to pay I.T.";
        }
    }
}
