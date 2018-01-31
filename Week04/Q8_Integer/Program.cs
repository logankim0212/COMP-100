using System;
/*
 * Write a program that allows the user to enter two integers and a character.
 * If the character is A, add the two integers.
 * If it is S, subtract the second integer from the first.
 * If it is M, multiply the integers.
 * Display the results of the arithmetic.
 */
namespace Q8_Integer
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter first integer: ");
            int first = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter second integer: ");
			int second = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter one character: ");
			string character = Console.ReadLine();
            if (character == "A" || character == "a")
            {
                int result = first + second;
                Console.WriteLine("{0} + {1} = {2}.", first, second, result);
            }
            else if (character == "S" || character == "s")
            {
                int result = first - second;
				Console.WriteLine("{0} - {1} = {2}.", first, second, result);
			}
            else if (character == "M" || character== "m")
            {
                int result = first * second;
				Console.WriteLine("{0} * {1} = {2}.", first, second, result);
			}
        }
    }
}
