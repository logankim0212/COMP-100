using System;
/*
 * To repeatedly prompt for a number and sum it. When the sum just exceeds 100,
 * stop the prompting and display the sum at the end. You must not display the
 * sum while the user in typing in numbers. (You do not need a counter but you 
 * will need some way of terminating the loop)
 */
namespace Q7_SumUntil100
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int number = 0;
            do
            {
                Console.Write("Enter a number: ");
                number += Convert.ToInt32(Console.ReadLine());
            } while (number < 100);
            Console.WriteLine("Sum of the numbers that you entered is {0}", number); 
        }
    }
}
