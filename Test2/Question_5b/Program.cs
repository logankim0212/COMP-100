using System;

namespace Question01
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = 1;
            char c1 = 'R';
            char c2 = 'Y';
            char c3 = 'G';
            char c4 = 'B';
            char c5 = 'P';
            rainbow(n, c1, c2, c3, c4, c5);
        }
        static void rainbow(int n, char c1, char c2, char c3, char c4, char c5)
        {
            for (int rows = 0; rows < (n + 1); rows++)
            {
                for (int cols = 0; cols < ((n * 4) + 2); cols++)
                {
                    if (rows + cols == n || cols - rows == (3 * n + 1) || rows == 0 && cols > n && cols < (n * 3 + 1))
                    {
                        Console.Write(c1);
                    }
                    else if (rows + cols == (n + 1) || cols - rows == (3 * n) || rows == 1 && cols > n && cols < (n * 3 + 1) && n >= 2)
                    {
                        Console.Write(c2);
                    }
                    else if (rows + cols == (n + 2) || cols - rows == (3 * n - 1) || rows == 2 && cols > n && cols < (n * 3 + 1) && n >= 3)
                    {
                        Console.Write(c3);
                    }
                    else if (rows + cols == (n + 3) || cols - rows == (3 * n - 2) || rows == 3 && cols > n && cols < (n * 3 + 1) && n >= 4)
                    {
                        Console.Write(c4);
                    }
                    else if (rows + cols == (n + 4) || cols - rows == (3 * n - 3) || rows == 4 && cols > n && cols < (n * 3 + 1) && n >= 5)
                    {
                        Console.Write(c5);
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
