using System;
/*
 * 1.   Write a program that calculates the tax on an item, based on the
 * province code. Your program will prompt the user for the 2-letter province
 * code, and the cost of the item and then computes the tax based on the
 * following table:
 *                  Province                     Rate
 *                     ON                         14%
 *                     PQ                         13%
 *             Any other province                 0%
 * Use named constants and if’s.
 * Try to accommodate all permutations of the 2-letter code.
 */
namespace Q14_Tax
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			Console.Write("Enter the cost of the item (in CAD): ");
			double cost = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the 2-letter province code (in all caps): ");
            string code = Console.ReadLine();
            if (code == "ON")
            {
                double aftertax = cost * 0.14;
                Console.WriteLine("Tax of the item in {0} is {1:c}. (14%)"
                                  , code, aftertax);
            }
            else if (code == "PQ" || code == "QC")
            {
                double aftertax = cost * 0.13;
                Console.WriteLine("Tax of the item in {0} is {1:c}. (13%)"
                                  , code, aftertax);
            }
            else if (code == "AB" || code == "BC" || code == "MB" || code ==
                     "NB" || code == "NL" || code == "NS" || code == "NT" ||
                     code == "NU" || code == "PE" || code == "SK" || code ==
                     "YT")
            {
                Console.WriteLine("There is no tax in {0}. So, tax is $0."
                                  , code); 
            }
            else
            {
                Console.WriteLine("{0} is not a province in Canada.", code); 
            }
        }
    }
}
