using System;
/*
 * Print the decimal, octal, and hexadecimal values of all characters between
 * the start and stop characters entered by a user. For example, if the user
 * enters an a and a z, the program should print all the characters between
 * a and z and their respective numerical values. Make sure that the second
 * character entered by the user occurs later in the alphabet than the first
 * character. If it does not, write a loop that repeatedly asks the user for a
 * valid second character until one is entered.
 * Your output should be formatted as shown below
 * Letter  Decimal Octal   Hex
 *   a       97     141     61
 *   b       98     142     62
 *   c       99     143     63
 *   d       100    144     64
 *   e       101    145     65
 * to obtain an int from a char use an explicit cast
 * to obtain an octal from an int use Convert.ToString(«number_value», 8)
 * to obtain a hexadecimal from an int use Convert.ToString(«number_value», 16)
 */
namespace Q11_For
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the first letter: ");
            char first = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter the last letter: ");
            char last = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();
            if (first < last)
            {
                Console.WriteLine("+--------+---------+---------+------+");
                Console.WriteLine("| Letter | Decimal |  Octal  |  Hex |");
                Console.WriteLine("+--------+---------+---------+------+");
                for (; first <= last; first++)
                {
                    string Octal = Convert.ToString(first, 8);
                    string Hex = Convert.ToString(first, 16);
                    Console.WriteLine("|    {0}   |   {1,3}   |   {2,3}   |  {3,2}  |", first, (int)first, Octal, Hex);
                }
                Console.WriteLine("+--------+---------+---------+------+");
            }
            else
            {
                for (; first >= last;)
                {
                    Console.Write("Enter the first letter: ");
                    first = Convert.ToChar(Console.ReadLine());
                    Console.Write("Enter the last letter: ");
                    last = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    if (first < last)
                    {
                        Console.WriteLine("+--------+---------+---------+------+");
                        Console.WriteLine("| Letter | Decimal |  Octal  |  Hex |");
                        Console.WriteLine("+--------+---------+---------+------+");
                        for (; first <= last; first++)
                        {
                            string Octal = Convert.ToString(first, 8);
                            string Hex = Convert.ToString(first, 16);
                            Console.WriteLine("|    {0}   |   {1,3}   |   {2,3}   |  {3,2}  |", first, (int)first, Octal, Hex);
                        }
                        Console.WriteLine("+--------+---------+---------+------+");
                        break;
                    }
                }
            }
        }
    }
}
