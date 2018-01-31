using System;
/*
 * To display the numbers 1 … 20 on separate lines with an asterisk after
 * the multiples of 5. (multiples besides asterisk)
 */
namespace Q4_NumberandStar
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int number = 1;
            do
            {
                if (number % 5 == 0)
                {
                    Console.WriteLine("{0} *", number); 
                }
                else
                {
                    Console.WriteLine(number); 
                }
                number = number + 1;
            } while (number <= 20);
        }
    }
}
