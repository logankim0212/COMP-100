using System;
/*
 * Write a console-based program that prompts a user for an hourly pay rate.
 * If the user enters values less than $7.50 or greater than $49.99, prompt
 * the user again. If the user enters an invalid value again, display an
 * appropriate error message. If the user enters a valid value on either the
 * first or second attempt, display the pay rate as well as the weekly rate,
 * which is calculated as 40 times the hourly rate.
 */
namespace Q10_HourlyRate
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter your hourly pay rate: ");
            double rate = Convert.ToInt32(Console.ReadLine());
            double weeklyrate = rate * 40;
            if (rate < 7.50 || rate > 49.99)
            {
                Console.WriteLine("Please enter the value between $7.50" +
                                  " and $49.99");
                Console.Write("Enter your hourly pay rate: ");
				double rate2 = Convert.ToInt32(Console.ReadLine());
                double weeklyrate2 = rate2 * 40;
                if (rate2 < 7.50)
                {
					Console.WriteLine("Error: {0:c} is less than the $7.50"
                                      , rate2);
                }
                else if (rate2 > 49.99)
                {
                    Console.WriteLine("Error: {0:c} is greater than $49.99."
                                      , rate2);
                }
                else
                {
					Console.WriteLine("Your hourly pay rate is {0:c} and" +
                                      "your weekly rate is {1:c}."
                                      , rate2, weeklyrate2);
                }
			}
            else
            {
                Console.WriteLine("Your hourly pay rate is {0:c} and your" +
                                  " weekly pay rate is {1:c}."
                                  , rate, weeklyrate);
            }
        }
    }
}
