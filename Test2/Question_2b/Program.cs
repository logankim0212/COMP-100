using System;
/*
 * =========================      Test #2 Fall 2017        =========================
 * 
 * Name: Logan Junhwi Kim
 * Student ID: 300-973-239
 *
 * Question 2b.
 * 10 Marks.
 *
 * Write a program that displays a conversion table of gram to ounces. The program
 * prompts the user for the end g and the start g value. The table must be in 
 * 10g decrements. You must match the format exactly.
 * 
 * Type of loop-> for
 * 1 g = 0.035 ounce
 * [Solution: Question2B]
 -------------------------------------------------------------------------------- */
namespace Question_2b
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int end, start;
            Console.Write("Enter the end gram value: ");
            end = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter start value: ");
            start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("gram    ounce");
            for (; start <= end; end -= 10)
            {
                Console.WriteLine("{0,3}    {1,6:f3}", (double)end, end*0.035);
            }
        }
    }
}
