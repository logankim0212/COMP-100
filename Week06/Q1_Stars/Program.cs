using System;
/*
 * To display five asterisks on a single line. Each asterisk must be separated
 * by a space. You must use a do-while loop to solve this program
 */
namespace Q1_Stars
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //initionalizer
            int counter = 0;
            do
            {
                Console.Write("* ");
                counter = counter + 1;
            } while (counter < 5);
        }
    }
}
