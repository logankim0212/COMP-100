using System;
/*
 * Write a program that prompts the user for the number of siblings his has.
 * The program should display a message, “I also have 4 siblings”
 * (assuming that the user enters 4).
 */
namespace Q2_Siblings
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string siblings;
            Console.Write("How many siblings do you have?: ");
            siblings = Console.ReadLine();
            Console.WriteLine("I also have {0} siblings.", siblings);
        }
    }
}
