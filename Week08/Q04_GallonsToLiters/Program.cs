using System;
/*
 * Write a C# program that displays a conversion table from gallons to liters.
 * The program should display gallons from 10 to 20 in one-gallon increments
 * and the corresponding liter equivalents. Use the relationship that 1 gallon
 * contains 3.785 liters
 */
namespace Q04_GallonsToLiters
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double gallons = 10, liters;
            Console.WriteLine("+-------------+--------------+"); 
            Console.WriteLine("|   Gallons   |    Liters    |");
            Console.WriteLine("+-------------+--------------+"); 
            do
            {
                liters = gallons * 3.785;
                Console.WriteLine("|   {0,3} G     |   {1,6:F3} L   |", gallons, liters);
                gallons += 1;
            } while (gallons <= 20);
            Console.WriteLine("+-------------+--------------+"); 
        }
    }
}
