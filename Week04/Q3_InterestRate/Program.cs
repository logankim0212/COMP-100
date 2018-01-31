using System;
/*
 * If money is left in a particular bank for more than 5 years, the interest
 * rate given by the bank is 7.5%, else the interest rate is 5.4%. Write a
 * program that prompt the user for the number of years that the money was
 * left in the bank and display the appropriate interest rate depending on the
 * value input. How many runs should you make to very that it works correctly?
 */
namespace Q3_InterestRate
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the number of years that the money" +
                          " was left in the bank: ");
            int years = Convert.ToInt32(Console.ReadLine());
            if (years > 5)
            {
                Console.WriteLine("The interest rate given by the bank" +
                                  " is 7.5%."); 
            }
            else
            {
                Console.WriteLine("The interest rate is 5.4%."); 
            }
            //We need to run at least 3 times in order to check that
            //the program works correctly.
        }
    }
}
