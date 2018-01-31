using System;
/*
 * Write a Program to compute the average of ten numbers which will be
 * entered by the user.
 */
namespace Q03_Averageof10Numbers
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
            } while (start <= 10);
            double final = number / 10;
            Console.WriteLine("The average of the 10 numbers that you entered" +
                              " is {0}", final);
        }
    }
}
