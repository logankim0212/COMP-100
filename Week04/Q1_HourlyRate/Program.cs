using System;
/*
 * Write a console-based program that prompts the user for an hourly pay rate.
 * If the value entered is less than $7.50, display an error message
 */
namespace Q1_HourlyRate
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter your hourly rate: ");
            double rate = Convert.ToDouble(Console.ReadLine());
            if (rate < 7.50)
            {
                Console.WriteLine("Error: {0:c} is less than the legal rate."
                                  , rate);
            }
        }
    }
}
