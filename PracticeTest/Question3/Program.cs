using System;

namespace Question3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the total cost of purchase: ");
            double cost = Convert.ToDouble(Console.ReadLine());
            double sellingprice;

            if (cost > 100)
            {
                sellingprice = cost * 0.9;
                Console.WriteLine("You need to pay {0:c}", sellingprice); 
            }
            else
            {
                Console.WriteLine("You need to pay {0:c}", cost); 
            }

        }
    }
}
