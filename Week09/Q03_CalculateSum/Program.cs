using System;
/* 
 * Write a method with the following specifications:
 * name: CalculateSum
 * arguments: int representing the number of input that will constitute the sum
 * return value: int representing the sum of its input
 * displays: nothing 
 * tasks: prompt and accepts inputs (as many as specified by the argument),
 * and sum them, Finally the method will return the sum of all the inputs (the sum) 
 * 
 * In your main you will call this method when the user enters 1 in response
 * to the menu choices. You will invoke this method with argument 5 and display
 * the resulting value.
 */

namespace Q03_CalculateSum
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
    }
}
