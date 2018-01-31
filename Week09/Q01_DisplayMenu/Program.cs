using System;

namespace Q01_DisplayMenu
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            DisplayMenu();
        }
        /*
         * Write a method with the following specifications:
         * name: DisplayMenu
         * arguments: none
         * return value: none
         * tasks: display the following menu choice on the screen
         * 
         * Calculation Menu
         * 1) Calculate Sum 
         * 2) Calculate Sum of Squares
         * 3) Calculate Sum of Cubes
         * 0) To Exit
         * 
         * Enter the number that corresponds to your choice: 
         * 
         * You may beautify the output to your own likings. You don’t have to
         * implement the functionalities of the various menu choices at this stage
         * Call this method from your main.
         */
        static void DisplayMenu()
        {
            Console.WriteLine("Calculation Menu");
            Console.WriteLine("1) Calculate Sum");
            Console.WriteLine("2) Calculate Sum of Squares");
            Console.WriteLine("3) Calculate Sum of Cubes");
            Console.WriteLine("0) To Exit");
            int choice = Convert.ToInt32(Console.ReadLine()); 
        }
    }
}
