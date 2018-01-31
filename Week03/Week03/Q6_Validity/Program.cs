using System;
/*
 * Write a program to ask the user about the validity of a simple statement.
 * The program should accept the response then display the statement as well
 * as the response. The response should be true or false. For this question,
 * you must use a variable of type bool.
 */
namespace Q6_Validity
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            bool statement;
            Console.WriteLine("Please type True/False for the statement below");
            Console.WriteLine("Steve Jobs was Apple's CEO.");
            Console.Write("Your answer is: ");
            statement = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Your answer is {0}.", statement);
        }
    }
}
