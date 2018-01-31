using System;

namespace Q6_Gift
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			//Input
			int priceofitem;
			int amountofmoney;
			//processing
			int totalcost;
			//Output
			int itemsbought;
			int leftover;
			//Algorithm
			Console.Write("Enter the price of the item: ");
			priceofitem = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter the amount of money that you have: ");
		
			amountofmoney = Convert.ToInt32(Console.ReadLine());
			itemsbought = amountofmoney / priceofitem;

			totalcost = priceofitem * itemsbought;

			leftover = amountofmoney - totalcost;

			Console.WriteLine(itemsbought);
			Console.WriteLine(leftover);

		}
    }
}
