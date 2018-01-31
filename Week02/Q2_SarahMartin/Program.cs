using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Sarah Martin has been working for Quality Builders for four
 * years. Last year, Sarah received a 4% raise, which brought
 * her current weekly pay to $250. Sarah is schedule to receive
 * a 3% raise next week. She wants you to write a program that
 * will display, on the computer screen, the amount of her new
 * weekly pay
 */
namespace Q2_SarahMartin
{
    class Program
    {
        static void Main(string[] args)
        {

            //Input
            int currentPay, rateIncrease;
            //Processing
            int payIncrease;
            //Output
            int newPay;
            //Algorithm
            Console.Write("Enter current pay: ");
            currentPay = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter rate increase: ");
            rateIncrease = Convert.ToInt32(Console.ReadLine());
            payIncrease = currentPay * rateIncrease / 100;
            newPay = currentPay + payIncrease;
            Console.WriteLine(newPay);


        }
    }
}
