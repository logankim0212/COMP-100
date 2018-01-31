using System;
/*
 * Saturdays and Wednesdays are Narendra’s days off. Write a program to prompt
 * the user for the day of the week. The program will display “Home day” or
 * “Work day” depending on the input. You and must use the following enum
 * declaration: enum Days { Mon, Tue, Wed, Thu, Fri, Sat, Sun }
 */
namespace Q6_DaysOff
{
    class MainClass
    {
		public enum Days
        { Mon, Tue, Wed, Thu, Fri, Sat, Sun }
        public static void Main(string[] arg)
        {
            Console.Write("Enter a day of the week (Enter only the first" +
                          " three letters of a day): ");
            Days day = (Days)Enum.Parse(typeof(Days), Console.ReadLine());
            switch (day)
            {
                case Days.Wed:
                case Days.Sat:
                    Console.WriteLine("Home Day");
                    break;
                default:
                    Console.WriteLine("Work Day");
                    break;
            }
        }
    }
}
