using System;

namespace Q09
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int rows = 8, cols = 15, num = 7, num2 = 7;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (col >= num && col <= num2)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
                num--;
                num2++;
            }
        }
    }
}
