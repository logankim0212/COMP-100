using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_JackOsaki
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int hours;
            int rate;
            //processing
            //output
            int weeklyPay;
            //Algorithm
            Console.Write("Enter hours ");
            hours = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter rate ");
            rate = Convert.ToInt32(Console.ReadLine());
            weeklyPay = hours * rate;
            Console.WriteLine(weeklyPay);

        }
    }
}
