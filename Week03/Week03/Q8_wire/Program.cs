using System;
/*
 * Write a program to calculate and display the potential difference between
 * the ends of a wire. The program will prompt the user for the current flowing
 * and the resistance of the wire. (Potential difference is the product of the
 * current and the resistance of the wire and may include a fractional part).
 */
namespace Q8_wire
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double current, resistance, difference;
            Console.Write("Enter the current: ");
            current = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the resistance: ");
            resistance = Convert.ToDouble(Console.ReadLine());

            difference = current * resistance;

            Console.WriteLine("The potential difference between the ends of a wire is {0:F}", difference); 

        }
    }
}
