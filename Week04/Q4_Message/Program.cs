using System;
/*
 * Write a console-based program that accepts a user’s message and determines
 * whether it is short enough for a social networking service that does not
 * accept messages of more than 140 characters.
 * [Hint: if the user’s input is assigned to the variable message then message.
 * Length with give the number of characters in the input]
 */
namespace Q4_Message
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter your message: ");
            string message = Console.ReadLine();
            if (message.Length < 140)
            {
                Console.WriteLine("The number of characters of your message" +
                                  " is {0}. Therefore, it is short enough" +
                                  " for a social networking service that" +
                                  " does not accept messages of more than" +
                                  " 140 characters", message.Length); 
            }
            else
            {
                Console.WriteLine("The number of characters of your message" +
                                  " is {0}. Therefore, it is too long for a" +
                                  " social networking service that does" +
                                  " not accept messages of more than 140" +
                                  " characters.", message.Length); 
            }
        }
    }
}
