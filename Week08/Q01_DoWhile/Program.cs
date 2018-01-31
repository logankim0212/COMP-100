using System;
/*
 * Write a program to print the numbers 2 to 10 in increments of two on the
 * same line. The output of your program should be 2 4 6 8 10 
 */
namespace Q01_DoWhile
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int start = 2, stop = 10, step = 2;
            do
            {
                Console.Write(start + " ");
                start += step;
            }
            while (start <= stop);


        }
    }
}
