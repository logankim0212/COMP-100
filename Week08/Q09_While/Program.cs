using System;
/*
 * Write a C program that continuously requests a gradehC to be entered.
 * If the grade is less than 0 or greater than 100, your program should print
 * an appropriate message informing the user that an invalid grade has been
 * entered, else the grade should be added to a total. When a grade of 999
 * is entered the program should exit the repetition loop and compute and
 * display the average of the valid grades entered.
 */
namespace Q09_While
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int grade = 0, number = 0, sum = 0;
            double average = 0;
            while (grade != 999)
            {
                Console.Write("Enter your grade: ");
                grade = Convert.ToInt32(Console.ReadLine());
                if (grade == 999)
                {
                    break;
                }
                else if (grade < 0 || grade > 100)
                {
                    Console.WriteLine("The grade you entered is not appropriate.");
                    Console.Write("Please enter it again: ");
                }
                else
                {
                    sum += grade;
                    number++;
                }
            }
            average = sum / number;
            Console.WriteLine("The average of your grade is {0:f}", average); 
        }
    }
}
