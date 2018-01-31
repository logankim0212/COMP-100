using System;
/*
 * Write a console-based program that prompts the user for an hourly pay rate
 * and hours worked. Compute gross pay (hours times pay rate), withholding tax,
 * and net pay (gross pay minus withholding tax). Withholding tax is computed
 * as a percentage of gross pay based on the following:
 *         Gross Pay                 Withholding Percentage
 * Up to and including 300.00                  10%
 *       More than300.00                       12%
 */
namespace Q6_NetPay
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter your hourly pay rate: ");
            double rate = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the hours that you worked: ");
            int hours = Convert.ToInt32(Console.ReadLine());
            double grosspay = rate * hours;
            if (grosspay <= 300.00)
            {
                double netpay = grosspay * 0.9;
                Console.WriteLine("Your net pay is {0:c}.", netpay); 
            }
            else
            {
                double netpay = grosspay * 0.88;
                Console.WriteLine("Your net pay is {0:c}.", netpay);
            }
        }
    }
}
