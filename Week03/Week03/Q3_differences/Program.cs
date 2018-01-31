using System;
/*
 * Write a program that prompts the user for two integers. The program will
 * display the result of summing and finding the difference.
 * (If the user enters 8 and 3, the display should be 8 + 3 = 11 and 8 – 3 = 5).
 */
namespace Q3_differences
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //input
            int firstvalue;
            int secondvalue;

            //processing

            //output
            int sum;
            int differences;

            //Algorithms
            Console.Write("Enter the first value: ");
            firstvalue = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second value: ");
            secondvalue = Convert.ToInt32(Console.ReadLine());

            sum = firstvalue + secondvalue;
            differences = firstvalue - secondvalue;

            Console.WriteLine("{0} + {1} = {2}", firstvalue, secondvalue, sum);
            Console.WriteLine("{0} - {1} = {2}", firstvalue, secondvalue, differences); 


        }
    }
}
