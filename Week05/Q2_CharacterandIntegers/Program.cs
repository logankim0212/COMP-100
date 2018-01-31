using System;
/*
 * Write a program that allows the user to enter two integers and a character
 * If the character is A, add the two integers If it is S, subtract the second
 * integer from the first else multiply the integers Display the results of the
 * arithmetic.
 */
namespace Q2_CharacterandIntegers
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the first integer: ");
            int first = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter the second integer: ");
			int second = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter a character: ");
			string character = Console.ReadLine();
            int result;

            switch (character)
            {
                case "A":
                case "a":
                    result = first + second;
                    Console.WriteLine("{0} + {1} = {2}. So, the result is {2}."
                                     , first, second, result); 
                    break;
				case "S":
                case "s":
					result = first - second;
					Console.WriteLine("{0} - {1} = {2}. So, the result is {2}."
									 , first, second, result);
					break;
                default:
					result = first * second;
					Console.WriteLine("{0} * {1} = {2}. So, the result is {2}."
									 , first, second, result);
					break;
            }
        }
    }
}
