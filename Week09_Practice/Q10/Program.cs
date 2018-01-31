using System;

namespace Q10
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int rows = 6, cols = 11;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (row == col || col + row == 10)
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
