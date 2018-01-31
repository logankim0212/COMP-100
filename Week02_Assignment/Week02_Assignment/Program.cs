using System;

namespace Week02_Assignment
{
    class MainClass
    {
        public static void Main(string[] args)
        {

			//input
			int income;
			int rent;
			//processing
			//output
			int profit;
			//Algorithm
			Console.Write("Enter the income from the sale of tickets, broadcasting rights and advertising: ");
			income = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter rent fee: ");
			rent = Convert.ToInt32(Console.ReadLine());
			profit = income - rent;
			Console.WriteLine(profit);

        }
    }
}
