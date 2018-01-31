using System;
/*
 * Modify your main so that the above method is call repeatedly.
 * The program will terminate when the user enters 0. Because you will not be
 * doing any arithmetic you may res the user response as an int, a char or a
 * string.
 */
namespace Q02_Repeat
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string choice = "1";
            while (choice != "0")
            {
                DisplayMenu();
                choice = Convert.ToString(Console.ReadLine()); 
            }
        }
        static void DisplayMenu()
        {
            Console.WriteLine("Calculation Menu");
            Console.WriteLine("1) Calculate Sum");
            Console.WriteLine("2) Calculate Sum of Squares");
            Console.WriteLine("3) Calculate Sum of Cubes");
            Console.WriteLine("0) To Exit");
        }
    }
}
