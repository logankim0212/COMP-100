using System;
/*
 * Write a program that prompts the user for a menu choice. The program will
 * display a message based on the following table:
 *          Choice                       Message
 *             1                     "Calculate area"
 *             2                    "Calculate volume"
 *             3                  "Calculate surface area"
 *             0                     "Exit the program"
 *    << any other input>>        "ERROR: Invalid choice "
 */
namespace Q1_Calculate
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the number of your choice: ");
            string number = Console.ReadLine();

            switch (number)
            {
                case "1":
					Console.WriteLine("Calculate area.");
					break;
				case "2":
					Console.WriteLine("Calculate volume.");
					break;
				case "3":
					Console.WriteLine("Calculate surface area.");
					break;
				case "0":
					Console.WriteLine("Exit the program.");
					break;
                default:
                    Console.WriteLine("Error: Invalid choice.");
                    break;
            }
        }
    }
}
