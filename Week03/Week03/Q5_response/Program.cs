using System;
/*
 * Write a program to prompt the user to enter a single character. The program
 * should display a message like “Your response was y”. For this question, you
 * must use a variable of type char.
 */
namespace Q5_response
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            char response;
            Console.Write("Type your response: ");
            response = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Your response was {0}.", response);
        }
    }
}
