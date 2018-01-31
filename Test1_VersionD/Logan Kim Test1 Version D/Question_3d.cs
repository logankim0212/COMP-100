using System;
/*
 * =========================      Test #1 Fall 2017      =================
 * 
 * Name: Logan Kim
 * Student ID: 300-973-239
 *
 * Question 3d.
 * 6 Marks.
 *
 * Write a program that prompts the user for a number. The program prints
 * the number and the letter equivalent. The letter equivalent is obtained
 * by casting the letter to an int. You must match the format exactly.
 * 
 * YOU MUST READ IN THE INPUT AS AN int and you MUST do an explicit cast
 * [For testing purposes use numbers in the range 48 to 90]
 * [Solution: Question3D]
 * [Hint: See Wk03_data_types.pptx slide #6 and #8]
 */
namespace Question_3d
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            int integer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The letter {0} is equivalent to the number {1}", (char)integer, integer); 
        }
    }
}
