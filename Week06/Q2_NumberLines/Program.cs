using System;
/*
 * To display the numbers 1 … 5 on separate lines
 */
namespace Q2_NumberLines
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int number = 1;
            do
            {
                Console.WriteLine(number);
                number = number + 1;
            } while (number < 6);
        }
    }
}
