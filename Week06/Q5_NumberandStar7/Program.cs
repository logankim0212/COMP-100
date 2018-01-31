using System;
/*
 * To display the numbers 10 … 40 on separate lines with an asterisk before
 * the multiples of 7. (asterisk besides multiples)
 */
namespace Q5_NumberandStar7
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int number = 10;
            do
            {
                if (number % 7 == 0)
                {
                    Console.WriteLine("* {0}", number);
                }
                else
                {
                    Console.WriteLine(number);
                }
                number = number + 1;
            } while (number <= 40);
        }
    }
}
