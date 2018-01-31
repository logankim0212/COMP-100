using System;
/*
 * A conversion table of Celsius to Fahrenheit temperature. The table must
 * start with 0 Celsius and end at 100 Celsius with increments of 10.
 * (Fahrenheit = Celsius * 9/5 + 32)
 */
namespace Q10_Temperature
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int celsius = 0, fahrenheit;
            Console.WriteLine("+-------------+----------------+"); 
            Console.WriteLine("|   Celsius   |   Fahrenheit   |");
            Console.WriteLine("+-------------+----------------+"); 
            do
            {
                fahrenheit = celsius * 9 / 5 + 32;
                Console.WriteLine("|    {0,3}°C    |      {1,3}°F     |", celsius, fahrenheit);
                celsius += 10;
            } while (celsius <= 100);
            Console.WriteLine("+-------------+----------------+"); 
        }
    }
}
