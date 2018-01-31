using System;
/*
 * Same as the previous question but additionally displays the average of the
 * numbers at the end of the loop. You will need a counter but not as a loop
 * terminator.
 */
namespace Q8_NumberAverage
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double number = 0, counter = 0;
            do
            {
                Console.Write("Enter a number: ");
                number += Convert.ToDouble(Console.ReadLine());
                counter++;
            } while (number < 100);
            double average = number / counter;
            Console.WriteLine("Sum of the numbers that you entered is {0}", number); 
            Console.WriteLine("Average of the numbers that you entered is {0}", average);
        }
    }
}
