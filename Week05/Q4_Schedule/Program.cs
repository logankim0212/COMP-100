using System;
/*
 * Write a program that prompts the user for a day of the week. The program
 * will display a message based on the following table:
 *              Choice                  Message
 *                Sun                    "Home"
 *                Mon                    "Work"
 *                Tue                    "Work"
 *                Wed                    "Home"
 *                Thu                    "Work"
 *                Fri                    "Work"
 *                Sat                    "Work"
 */
namespace Q4_Schedule
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a day of the week (Enter only the first" +
                              " three letters of a day): ");
            string day = Console.ReadLine();
            switch (day.ToLower())
            {
                case "sun":
                    Console.WriteLine("Home");
                    break;
                case "mon":
					Console.WriteLine("Work");
					break;
				case "tue":
					Console.WriteLine("Work");
					break;
				case "wed":
					Console.WriteLine("Home");
					break;
				case "thu":
					Console.WriteLine("Work");
					break;
				case "fri":
					Console.WriteLine("Work");
					break;
				case "sat":
					Console.WriteLine("Work");
					break;
            }
        }
    }
}
