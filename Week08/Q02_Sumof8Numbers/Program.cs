using System;
/*
 * Write a Program to compute the sum of eight numbers that will be
 * provided by the user.
 */
namespace Q02_Sumof8Numbers
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int start = 1;
            double number = 0;
            do
            {
                Console.Write("Enter the number {0}: ", start);
                number += Convert.ToDouble(Console.ReadLine());
                start += 1;
            } while (start <= 8);
            Console.WriteLine("The sum of the 8 numbers that you entered" +
                              " is {0}", number);
        }
    }
}
