using System;
/*
 * =========================      Test #2 Fall 2017      =========================
 * 
 * Name: Logan Junhwi Kim
 * Student ID: 300-973-239
 *
 * Question 3b.
 * 8 Marks.
 *
 * Write a program that prints multiples of 7 in ascending order on a single line.
 * The program prompts the user for the end value. 
 * 
 * Type of loop-> do while
 * [Solution: Question3B]
 -------------------------------------------------------------------------------- */
namespace Question_3b
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int end, value = 7;
            Console.Write("Enter end value: ");
            end = Convert.ToInt32(Console.ReadLine()); 
            do
            {
                Console.Write(value + " ");
                value += 7;
            } while (value < end);

        }
    }
}
