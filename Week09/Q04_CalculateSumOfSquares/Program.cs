using System;
/*
 * Write a method with the following specifications:
 * name: CalculateSumOfSquares
 * arguments: int representing the number of input that will constitute the sum
 * return value: int representing the sum of the squares of its input
 * displays: nothing 
 * tasks: prompt the user for inputs and accumulates the sum of the squares of
 * the input. This is repeated as specified by the argument. Returns the final sum 
 * 
 * In your main when the user enters 2 in response to the menu choices,
 * you will prompt the user for the number of inputs that she will be working with.
 * You will invoke this method with this value and display the resulting value.
 */

namespace Q04_CalculateSumOfSquares
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string choice;
            do
            {
                DisplayMenu();
                choice = Convert.ToString(Console.ReadLine());
                int number, sum;
                switch (choice)
                {
                    case "1":
                        Console.Write("How many numbers do you want to sum?: ");
                        number = Convert.ToInt32(Console.ReadLine());
                        sum = CalculateSum(number);
                        Console.WriteLine("Sum of the numbers that you entered is {0}", sum);
                        break;
                    case "2":
                        Console.Write("How many numbers of the square do you want to sum?: ");
                        number = Convert.ToInt32(Console.ReadLine());
                        sum = CalculateSumOfSquares(number);
                        Console.WriteLine("Sum of the squares of the numbers that you entered is {0}", sum);
                        break;
                }
            } while (choice != "0");
        }
        static void DisplayMenu()
        {
            Console.WriteLine("Calculation Menu");
            Console.WriteLine("1) Calculate Sum");
            Console.WriteLine("2) Calculate Sum of Squares");
            Console.WriteLine("3) Calculate Sum of Cubes");
            Console.WriteLine("0) To Exit");
        }

        static int CalculateSum(int number)
        {
            int start, sum = 0, num;
            for (start = 1; start <= number; start++)
            {
                Console.Write("Enter the {0} number: ", start);
                num = Convert.ToInt32(Console.ReadLine());
                sum += num;
            }
            return sum;
        }

        static int CalculateSumOfSquares(int number)
        {
            int start, sum = 0, num;
            for (start = 1; start <= number; start++)
            {
                Console.Write("Enter the {0} number: ", start);
                num = Convert.ToInt32(Console.ReadLine());
                sum += num * num;
            }
            return sum;
        }
    }
}
