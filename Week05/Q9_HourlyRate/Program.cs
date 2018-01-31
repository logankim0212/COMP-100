using System;
/*
 * Write a program that prompts the user or an hourly pay rate.
 * If the value entered is less than $5 65, display an error message.
 */
namespace Q9_HourlyRate
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter your hourly pay rate: ");
            double payrate = Convert.ToInt32(Console.ReadLine());
            if (payrate < 5.65)
            {
                Console.WriteLine("Error.");
            }
        }
    }
}
