﻿using System;
/*
 * 10.  Write and run a C# program that calculates and displays the amount of
 * money available in a bank account that initially has $1,000 deposited in it
 * and that earns 8 percent interest a year. Your program should display the
 * amount available at the end of each year for a period of ten years. Use the
 * relationship that the money available at the end of each year equals the
 * amount of money in the account at the start of the year plus .08 times
 * the amount available at the start of the year.
 * Your output should be formatted as shown below
 * Year    Balance
 *  1     $1,080.00
 *  2     $1,166.40
 *  3     $1,259.71
 *  4     $1,360.49
 *  5     $1,469.33
 *  6     $1,586.87
 *  7     $1,713.82
 *  8     $1,850.93
 *  9     $1,999.00
 *  10    $2,158.92
 */
namespace Q10_While
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("+--------+---------------+");
            Console.WriteLine("|  Year  |    Balance    |");
            Console.WriteLine("+--------+---------------+");
            int year = 1;
            double balance = 1000;
            while (year <= 10)
            {
                balance = balance * 1.08;
                Console.WriteLine("|   {0,2}   |   {1,8:c}   |", year, balance); 
                year++;
            }
            Console.WriteLine("+--------+---------------+");

        }
    }
}
