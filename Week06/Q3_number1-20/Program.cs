using System;
/*
 * To display the numbers 1 … 20 on separate lines
 */
namespace Q3_number120
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
            } while (number <= 20);
        }
    }
}
