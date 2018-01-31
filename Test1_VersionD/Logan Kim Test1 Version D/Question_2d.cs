using System;
/*
 * =========================      Test #1 Fall 2017      =================
 * 
 * Name: Logan Kim
 * Student ID: 300-973-239
 *
 * Question 2d.
 * 12 Marks.
 *
 * Write a program that prompts the user for a company name and his annual
 * salary.The  program displays the name of the company and the monthly 
 * salary. You must match the  format exactly.
 * 
 * Hint: monthly salary is annual salary divided by 12
 * [Solution: Question2D]
 */
namespace Question_2d
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the company name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your annual salary: ");
            double annualsalary = Convert.ToDouble(Console.ReadLine());
            double monthlysalary = annualsalary / 12;
            Console.WriteLine("The monthly salary at {0} is {1:c}", name, monthlysalary); 
        }
    }
}
