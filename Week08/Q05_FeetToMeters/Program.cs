using System;
/*
 * Write a C# program that converts feet to meters. The program should display
 * feet from 3 to 30 in three-foot increments and the corresponding meter
 * equivalents. Use the relationship that 1 meter is equivalent to 3.28 feet.
 */
namespace Q05_FeetToMeters
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double feet = 3, meters;
            Console.WriteLine("+-------------+--------------+"); 
            Console.WriteLine("|    Feet     |    Meters    |");
            Console.WriteLine("+-------------+--------------+"); 
            do
            {
                meters = feet * 3.28;
                Console.WriteLine("|   {0,3} ft    |   {1,6:F} m   |", feet, meters);
                feet += 3;
            } while (feet <= 30);
            Console.WriteLine("+-------------+--------------+"); 
        }
    }
}
