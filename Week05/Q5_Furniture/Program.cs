using System;
/*
 * Write a program for a furniture company. Ask the user to choose Pine Oak or
 * Mahogany. Show the price of a table manufactured with the chosen wood Pine
 * tables cost $100, Oak tables cost $225, and Mahogany tables cost $310.
 * Use named constants and switch.
 */
namespace Q5_Furniture
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the meterial that you want ('P' for Pine," +
                          " 'O' for Oak, 'M' for mahogany): ");
            string meterial = Console.ReadLine();

            switch (meterial)
            {
                case "P":
                case "p":
                    Console.WriteLine("You chose Pine. Pine tables cost $100."); 
                    break;
				case "O":
				case "o":
					Console.WriteLine("You chose Oak. Oak tables cost $225.");
					break;
				case "M":
				case "m":
					Console.WriteLine("You chose Mahogany. Mahogany tables" +
                                      " cost $310.");
					break;
            }
        }
    }
}
