using System;
/*
 * Write a program that prompts the user for the number of courses and
 * residency status (domestic or international) and calculates tuition cost.
 * Cost is calculated based on the table below.
 *          Domestic                $325 per course
 *        International             $1375 per course
 * You decide how you want the user to enter her/his residency status and
 * prompt accordingly, also you should use named constants for the cost
 * per course.
 */
namespace Q3_TuitionCost
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter your residency status (Enter 'D' if you are" +
                          " domestic, or 'I' if you are international): ");
            String residency = Console.ReadLine();
            Console.Write("Enter the number of courses that you are taking: ");
            int courses = Convert.ToInt32(Console.ReadLine());
            int tuition;

            switch (residency)
            {
                case "I":
                case "i":
                    tuition = courses * 1375;
                    Console.WriteLine("Your tuition cost is {0:c}.", tuition); 
                    break;
				case "D":
				case "d":
					tuition = courses * 325;
					Console.WriteLine("Your tuition cost is {0:c}.", tuition);
					break;
            }
        }
    }
}
