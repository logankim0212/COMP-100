using System;

namespace Q07
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int rows = 8, cols = 8;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (row == 0 || col == 0 || row == 7 || col == 7)
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
