using System;

namespace Q01
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int rows = 3, cols = 8;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
