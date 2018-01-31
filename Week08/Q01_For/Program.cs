using System;
/* Write a C# program that converts feet to meters. The program should display
 * feet from 3 to 30 in three-foot increments and the corresponding meter
 * equivalents.Use the relationship that 1 meter is equivalent to 3.28 feet.
 */
namespace Q1_For
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            for (int start = 2, stop = 10, step = 2; start <= stop; start += step)
            {
                Console.Write(start + " ");
            }
        }
    }
}
