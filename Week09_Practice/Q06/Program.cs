using System;

namespace Q06
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int rows = 21, cols = 76;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (row + col == 7 || (row + col)%7 == 0)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
