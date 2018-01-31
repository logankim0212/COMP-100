using System;
/*
 * Write a program that displays a conversion table from Fahrenheit to Celsius.
 * The program must request the starting Fahrenheit value, the ending
 * Fahrenheit value, and the increment. Thus, instead of the condition checking
 * for a fixed count, the condition checks for the ending Fahrenheit value
 */
namespace Q06_FahreneitToCelsius
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the starting Fahrenheit value: ");
            double start = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the ending Fahrenheit value: ");
            double end = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the increment: ");
            double increment = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = start, celsius;
            Console.WriteLine("+-------------+----------------+");
            Console.WriteLine("|   Celsius   |   Fahrenheit   |");
            Console.WriteLine("+-------------+----------------+");
            do
            {
                celsius = (fahrenheit - 32) / 9 * 5;
                Console.WriteLine("|  {0,6:f}°C   |    {1,6:f}°F    |", celsius, fahrenheit);
                fahrenheit += increment;
            } while (fahrenheit <= end);
            Console.WriteLine("+-------------+----------------+");
        }
    }
}
