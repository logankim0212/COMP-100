using System;

namespace Q02
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int rows = 7, cols = 7;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (row == col)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
