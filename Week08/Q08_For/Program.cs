using System;
/*
 * Write a program to produce a table of numbers from 10 to 1, with their
 * squares and cubes.
 */
namespace Q08_For
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            for (int start = 10, step = 1, stop = 1, squares, cubes; start >= stop; start -= step)
            {
                squares = start * start;
                cubes = start * squares;
                Console.WriteLine("   {0,3}   |   {1,3}   |   {2,4}   ", start, squares, cubes);
            }
        }
    }
}
