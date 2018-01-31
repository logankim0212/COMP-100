using System;
/*
 * Write a program to produce a table of the numbers 0 through 20 in increments
 * of 2, with their squares and cubes.
 */
namespace Q07_While
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int number = 2, step = 2, stop = 20;
            while (number <= stop)
            {
                Console.Write(number + " ");
                number += step;
            }
        }
    }
}
