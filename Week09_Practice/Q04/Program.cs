using System;

namespace Q04
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int rows = 9, cols = 9;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (row + col == 8 || row == col)
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
