using System;

namespace Q08
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int rows = 5, cols = 12, num = 0;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (col >= num && col <= (num + 7))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
                num++;
        }
    }
}
