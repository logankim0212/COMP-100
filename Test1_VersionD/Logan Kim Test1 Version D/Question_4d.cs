using System;
/*
 * =========================      Test #1 Fall 2017      =================
 * 
 * Name: Logan Kim
 * Student ID: 300-973-239
 *
 * Question 4d.
 * 14 Marks.
 *
 * Canada Computer Store has asked you to write a program that prompts the
 * user for the device that she would like to pruchase. Based on the 
 * user's input the program will display the following:
 * 
 * Input: tablet
 * Message: A tablet cost $475.00
 * 
 * Input: LAPTOP
 * Message: A LAPTOP cost $650.00
 * 
 * Input: Desktop
 * Message: A Desktop cost $899.00
 * 
 * any other input
 * Message: I am sorry I don't carry those devices
 * 
 * You may use either the ToUpper() or ToLower() methods 
 * 
 * You must use a SWITCH statement as the ONLY branching structure to 
 * solve this problem
 * [For full marks you need to accept all permutations of tablet, laptop 
 * and desktop]
 * 
 * [Solution: Question4D]
 */
namespace Question_4d
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("What is kind of device would you like to buy? ");
            string kind = Console.ReadLine();
            switch (kind.ToLower())
            {
                case ("tablet"):
                    Console.WriteLine("A {0} cost $475.00", kind);
                    break;
                case ("laptop"):
                    Console.WriteLine("A {0} cost $650.00", kind);
                    break;
                case ("desktop"):
                    Console.WriteLine("A {0} cost $899.00", kind);
                    break;
                default:
                    Console.WriteLine("I am sorry I don't carry those devices");
                    break;
            }
        }
    }
}
