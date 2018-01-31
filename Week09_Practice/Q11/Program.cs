using System;

namespace Q11
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int rows = 9, cols = 9, num = 4, num2 = 4;
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
                if (row < 4)
                {
                    num--;
                    num2++;
                }
                else
                {
                    num++;
                    num2--;
                }
            }
        }
    }
}
