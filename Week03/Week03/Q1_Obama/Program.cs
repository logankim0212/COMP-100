using System;
/*
 *1.    Create a program that prompts the user for her first name, middle
 *initial and last name. The program will display the user name three times
 *using the following three formats: 
 *first name and last name
 *first name middle initial and last name
 *lst name, first name and middle initial
 *For inputs Barack H Obama
 *Barack Obama
 *Barack H Obama
 *Obama, Barack H
 */
namespace Q1_Obama
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string first, middle, last;
            Console.Write("Enter your first name: ");
            first = Console.ReadLine();
            Console.Write("Enter the initial of your middle name: ");
            middle = Console.ReadLine();
            Console.Write("Enter your last name: ");
            last = Console.ReadLine();
            Console.WriteLine(first + " " + last);
            Console.WriteLine("{0} {1}", first, last);
            Console.WriteLine("{0} {1} {2}", first, middle, last);
			Console.WriteLine("{2}, {0} {1}", first, middle, last);

		}
    }
}
