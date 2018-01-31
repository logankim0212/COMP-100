using System;
/*
 * To display the sum of all the multiples of 3 between 1000000 and 2000000.
 * (Answer = 499, 999, 500, 000). If the sum might be larger than 2billion then
 * the type of sum should be a long and not an int. [Hint: like the C (currency)
 * and the  F (decimal) format specifiers, there is also a N specifier]

 */
namespace Q9_2billions
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int number = 1000000;
            long sum = 0;
            do
            {
                if (number % 3 == 0)
                {
                    sum = sum + number;
                }
                number++;
            } while (number < 2000000);
            Console.WriteLine("The sum is {0:n}", sum); 
        }
    }
}
