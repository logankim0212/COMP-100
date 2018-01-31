using System;

namespace Q9_Stephanie
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			//Input
			int candyprice;
			int moneyamount;
			//processing
			//Output
			int candyamount;
			int remainmoney;
			//Algorithm
            Console.Write("Enter the price of the candy (dollars): ");
			candyprice = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the amount of money that you would like to spend (dollars): ");
			moneyamount = Convert.ToInt32(Console.ReadLine());

			candyamount = moneyamount / candyprice;

			remainmoney = moneyamount - candyprice * candyamount;


			Console.WriteLine(candyamount);
			Console.WriteLine(remainmoney);
        }
    }
}
