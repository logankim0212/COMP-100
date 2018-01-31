using System;
/*
 * =========================      Test #2 Fall 2017        =========================
 * 
 * Name: Logan Junhwi Kim
 * Student ID: 300-973-239
 *
 * Question 1b.
 * 10 Marks.
 *
 * Write a program that adds the user input to reach a target. When the sum reaches 
 * just exceeds the target, the program prints the final sum and the number of user
 * inputs required
 * 
 * Type of loop-> while
 * [Solution: Question1B]
 -------------------------------------------------------------------------------- */
namespace Question_1b
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int value, sum = 0, number = 0, num;
            Console.Write("Enter targer value: ");
            value = Convert.ToInt32(Console.ReadLine());
            while (sum < value)
            {
                number++;
                Console.Write("Enter #{0}: ", number);
                num = Convert.ToInt32(Console.ReadLine());  
                sum += num;
            }
            Console.WriteLine("It took {0} inputs to take the sum to {1}", number, value);
        }
    }
}
