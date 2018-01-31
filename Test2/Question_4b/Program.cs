using System;
/*
 * =========================      Test #2 Fall 2017        =========================
 * 
 * Name: Logan Junhwi Kim
 * Student ID: 300-973-239
 *
 * Question 4b.
 * 12 Marks.
 *
 * Write a program that displays the table show in the sample executable.
 * 
 * the relationship is given by the quadratic equation
 *             y = y = 2x^2 + x - 6
 *    
 * Type of loop-> your favorite (your MUST use a loop)
 * Hints:
 *  1) Generate the first column using a place holder (increment = 0.25)
 *  2) Generate successive columns one at a time by adding another placeholder
 *  3) Format using column specifier (do not use tabs)
 *     
 * [Solution: Question4B]
 -------------------------------------------------------------------------------- */
namespace Question_4b
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double b, y;
            Console.WriteLine("    x   2x^2      +x    -6      y");
            Console.WriteLine(" ----   ----    ----  ----   ----");
            for (double x = -2.50; x <= 2.00; x += 0.25)
            {
                b = 2 * x * x;
                y = b + x - 6;
                Console.WriteLine("{0,5:f}  {1,5:f}   {2,5:f} -6.00  {3,5:f}"
                                  , x, b, x, y); 
            }
        }
    }
}
