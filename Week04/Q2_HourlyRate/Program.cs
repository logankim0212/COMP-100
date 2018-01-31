using System;
/*
 * Write a console-based program that prompts a user for an hourly pay rate.
 * If the value entered is less than $7.50 or greater than $49.99, display an
 * error message; otherwise, display a message indicating that the rate is okay.
 */
namespace Q2_HourlyRate
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter your hourly rate: ");
            double rate = Convert.ToDouble(Console.ReadLine());
            if (rate < 7.50 || rate > 49.99)
            {
				Console.WriteLine("Error: {0:c} is less than the legal rate."
                                  , rate);
			}
            else
            {
				Console.WriteLine("{0:c} is okay.", rate);
			}
        }
    }
}
