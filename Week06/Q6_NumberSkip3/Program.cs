using System;
/*
 * To display numbers 20 … 60 on separate lines skipping the multiple of 3.
 * You must print a blank line for each multiple.
 */
namespace Q6_NumberSkip3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int number = 20;
            do
            {
                if (number % 3 == 0)
                {
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine(number);
                }
                number = number + 1;
            } while (number <= 60);
        }
    }
}
