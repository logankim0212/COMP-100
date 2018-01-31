using System;
/*
 * 1.   Write a program that prompts the user for the number of siblings his
 * has. The program should display a message, “I have 4 siblings”
 * (assuming that the user enters 3).
 */
namespace Q4_siblings2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int siblings;
            int all;
            Console.Write("How many siblings do you have?: ");
            siblings = Convert.ToInt32(Console.ReadLine());
            all = siblings + Convert.ToInt32("1");
            Console.WriteLine("I have {0} siblings.", all);
        }
    }
}
